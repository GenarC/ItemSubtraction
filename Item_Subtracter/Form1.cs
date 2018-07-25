using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Item_Subtracter.DataModel;
using Microsoft.Office.Interop.Excel;

namespace Item_Subtracter
{
    public partial class Form1 : Form
    {
        List<IGrouping<string,MPN_List>> mpn_ime = new List<IGrouping<string, MPN_List>>();
        List<string> MPN_Listesi = new List<string>();
        IMEEntities db;

        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            db = new IMEEntities();
        }
        
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (mpn_ime.Count == 0)
            {
                MessageBox.Show("MPN Listesi Hazır Değil, Önce MPN Listesini Yükleyin");
            }
            else
            {
                dgItems.Rows.Clear();
                List<string> Ham_MPN_Listesi = new List<string>();
                List<string> Donusturulmus_MPN_Listesi = new List<string>();
                List<MPN> result = new List<MPN>();


                if (ChooseFile(Ham_MPN_Listesi))
                {
                    foreach (string mpn in Ham_MPN_Listesi)
                    {
                        Donusturulmus_MPN_Listesi.Add(RemoveIgnoredCharacters(mpn));
                    }

                    List<string> urun_bulunan_mpnler = new List<string>();
                    foreach (string mpn in Donusturulmus_MPN_Listesi)
                    {
                        string tempMPN = mpn.ToString();
                        List<string> b = MPN_Listesi.Where(x => x != null && x.Contains(tempMPN)).ToList();

                        if (b.Count() > 0)
                        {
                            int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x.Contains(tempMPN));

                            urun_bulunan_mpnler.Add(Ham_MPN_Listesi[ham_mpn_indexi]);
                        }
                        else
                        {
                            SearchItemWithMPN_InsertIntoFoundMPNs(tempMPN, b, Donusturulmus_MPN_Listesi, urun_bulunan_mpnler, Ham_MPN_Listesi);
                        }

                        //Bulunan ilk MPN'i değil, eşleşme olan tüm MPN'ler getirilmeli
                        var a = MPN_Listesi.Where(x => x != null && x.Contains(tempMPN)).ToList();


                        if (a.Count > 0)
                        {
                            foreach (string item in a)
                            {
                                int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x == mpn);
                                int index_a = MPN_Listesi.FindIndex(x => x == item);
                                string __mpn = mpn_ime[index_a].Key.ToString();
                                List<CompleteItems_v2> mpn_bulunan_urunler = db.CompleteItems_v2.Where(x => x.MPN == __mpn).ToList();

                                MPN _mpn = new MPN();
                                _mpn.LineNo = ham_mpn_indexi + 1;
                                _mpn.customerMPN = Ham_MPN_Listesi[ham_mpn_indexi];
                                _mpn.items = mpn_bulunan_urunler.ToList();
                                result.Add(_mpn);
                            }
                        }
                        else
                        {
                            int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x == mpn);
                            MPN m = new MPN();
                            m.LineNo = ham_mpn_indexi + 1;
                            m.customerMPN = Ham_MPN_Listesi[ham_mpn_indexi];
                            m.items = new List<CompleteItems_v2>();

                            result.Add(m);
                        }
                    }

                    List<_Item> items = new List<_Item>();
                    foreach (MPN item in result)
                    {
                        if (item.items.Count > 0)
                        {
                            foreach (CompleteItems_v2 i in item.items)
                            {
                                _Item x = new _Item();
                                x.LineNo = item.LineNo;
                                x.customerMPN = item.customerMPN;
                                x.item = i;

                                items.Add(x);
                            }
                        }
                        else
                        {
                            _Item x = new _Item();
                            x.LineNo = item.LineNo;
                            x.customerMPN = item.customerMPN;
                            x.item = null;

                            items.Add(x);
                        }

                    }

                    foreach (_Item item in items)
                    {
                        ItemDetailFill_Row(item);
                    }

                    string temp = String.Empty;
                    Color c = new Color();
                    foreach (DataGridViewRow row in dgItems.Rows)
                    {
                        if (temp != row.Cells[dgMPN.Index].Value.ToString())
                        {
                            temp = row.Cells[dgMPN.Index].Value.ToString();
                            c = Color.FromArgb((100 + rnd.Next(128)), (100 + rnd.Next(128)), (100 + rnd.Next(128)));
                        }
                        row.DefaultCellStyle.BackColor = c;
                    }
                }
                else
                {
                    MessageBox.Show("File not selected!", "Excel");
                }
            }
        }
        
        void SearchItemWithMPN_InsertIntoFoundMPNs(string tempMPN, List<string> list, List<string> convertedMpnList, List<string> ItemFoundMPNs, List<string> RawMPNList)
        {
            if (tempMPN.Length >= 8)
            {
                tempMPN = tempMPN.Substring(0, tempMPN.Length - 2);
                list = MPN_Listesi.Where(x => x != null && x.Contains(tempMPN)).ToList();
                if (list.Count() > 0)
                {
                    int ham_mpn_indexi = convertedMpnList.FindIndex(x => x.Contains(tempMPN));

                    ItemFoundMPNs.Add(RawMPNList[ham_mpn_indexi]);
                }
                else
                {
                    SearchItemWithMPN_InsertIntoFoundMPNs(tempMPN, list, convertedMpnList, ItemFoundMPNs, RawMPNList);
                }
            }
        }

        private void GetAllItems()
        {
            mpn_ime = db.MPN_List.GroupBy(x => x.MPN).ToList();
            foreach (var item in mpn_ime)
            {
                if (item.Key != null)
                {
                    MPN_Listesi.Add(RemoveIgnoredCharacters(item.Key));
                }
                else
                {
                    MPN_Listesi.Add(null);
                }
            }
        }

        private string RemoveIgnoredCharacters(string mpn)
        {
            string temp_mpn = mpn.Replace("-", "");
            temp_mpn = temp_mpn.Replace("_", "");
            temp_mpn = temp_mpn.Replace("/", "");
            temp_mpn = temp_mpn.Replace("&", "");
            temp_mpn = temp_mpn.Replace(" ", "");
            temp_mpn = temp_mpn.Replace("\"", "");
            temp_mpn = temp_mpn.Replace("#", "");
            temp_mpn = temp_mpn.Replace("^", "");
            temp_mpn = temp_mpn.Replace("(", "");
            temp_mpn = temp_mpn.Replace(")", "");
            temp_mpn = temp_mpn.Replace(",", "");
            temp_mpn = temp_mpn.Replace("+", "");
            temp_mpn = temp_mpn.Replace("*", "");
            temp_mpn = temp_mpn.Replace("!", "");
            temp_mpn = temp_mpn.Replace("%", "");
            temp_mpn = temp_mpn.Replace("\\", "");
            temp_mpn = temp_mpn.Replace("=", "");
            temp_mpn = temp_mpn.Replace("?", "");
            temp_mpn = temp_mpn.Replace(".", "");
            temp_mpn = temp_mpn.Replace(",", "");
            return temp_mpn;
        }

        private bool ChooseFile(List<string> Ham_MPN_Listesi)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.xlsx)|*.xlsx";
            DialogResult result1 = dialog.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excel.Workbooks.Open(dialog.FileName);
                Worksheet ws = wb.Worksheets[1];
                int i = 2;
                while (!String.IsNullOrEmpty(ws.Cells[i, 1].Value?.ToString()))
                {
                    string text = ws.Cells[i, 1].Value.ToString();
                    Ham_MPN_Listesi.Add(text);
                    i++;
                }

                wb.Close(0);
                excel.Quit();
                Marshal.ReleaseComObject(excel);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void ItemDetailFill_Row(_Item rowItem)
        {
            DataGridViewRow row = dgItems.Rows[dgItems.Rows.Add()];

            row.Cells[dgNo.Index].Value = rowItem.LineNo;
            row.Cells[dgMPN.Index].Value = rowItem.customerMPN;
            row.Cells[dgRsMPN.Index].Value = rowItem.item?.MPN;
            row.Cells[dgArticleNo.Index].Value = rowItem.item?.Article_No;
            int? qty = 0;
            if(rowItem.item?.Pack_Quantity > rowItem.item?.Unit_Content)
            {
                qty = (int)rowItem.item?.Pack_Quantity;
            }
            else
            {
                qty = rowItem.item?.Unit_Content;
            }
            row.Cells[dgPackQuantity.Index].Value = qty;
            if (rowItem.item != null)
            {
                row.Cells[dgUnitMeasure.Index].Value = (!String.IsNullOrEmpty(rowItem.item?.Unit_Measure)) ? rowItem.item.Unit_Measure : "EACH";
            }
            row.Cells[dgArticleDesc.Index].Value = rowItem.item?.Article_Desc;
            row.Cells[dgManufacturer.Index].Value = rowItem.item?.Manufacturer;
            row.Cells[dgStockQuantity.Index].Value = (rowItem.item?.OnhandStockBalance != null) ? rowItem.item?.OnhandStockBalance.ToString() : "";


            if(rowItem.item?.OnhandStockBalance <= 0 && rowItem.item?.CatalogueStatus != null)
            {
                if (rowItem.item?.CatalogueStatus == 2)
                {
                    row.Cells[dgStockQuantity.Index].Value = "FD";
                    row.Cells[dgStockQuantity.Index].Style.ForeColor = Color.Red;
                }
                else if (rowItem.item?.CatalogueStatus == 3)
                {
                    row.Cells[dgStockQuantity.Index].Value = "D";
                    row.Cells[dgStockQuantity.Index].Style.ForeColor = Color.Red;
                }
            }

            row.Cells[dgPrice.Index].Value = (rowItem.item?.Col1Price * Convert.ToDecimal(7.2));
            row.Cells[dgMHCodeLevel1.Index].Value = rowItem.item?.MH_Code_Level_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Yükleniyor";
            label1.ForeColor = Color.MidnightBlue;
            this.Refresh();
            try
            {
                GetAllItems();
                label1.Text = "Liste Hazır";
                label1.ForeColor = Color.Green;
                button1.Visible = false;
            }
            catch
            {
                label1.Text = "Liste Yüklenemedi!";
                label1.ForeColor = Color.Red;
            }
        }
    }

    class MPN
    {
        public int LineNo { get; set; }
        public string customerMPN { get; set; }
        public List<CompleteItems_v2> items { get; set; }
    }

    class _Item
    {
        public int LineNo { get; set; }
        public string customerMPN { get; set; }
        public CompleteItems_v2 item { get; set; }
    }

    class ExcelItem
    {
        public string MPN { get; set; }
        public int Quantity { get; set; }
    }
}
