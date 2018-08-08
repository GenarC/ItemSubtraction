using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //List<IGrouping<string,MPN_List>> __mpn_ime = new List<IGrouping<string, MPN_List>>();
        List<string> mpn_ime = new List<string>();
        List<string> MPN_Listesi = new List<string>();
        IMEEntities db;

        string _tempMPN;
        int removedWordCount = 0;
        int matchingItemCount = 0;
        List<Color> ColorList = new List<Color>();

        string LogString = "MPN Listesi Hazır Değil";

        private Random rnd = new Random();
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            db = new IMEEntities();
            ColorList.Add(Color.FromArgb(244, 176, 132));
            ColorList.Add(Color.FromArgb(180, 198, 231));
            ColorList.Add(Color.FromArgb(183, 240, 154));
            ColorList.Add(Color.FromArgb(246, 180, 92));
            ColorList.Add(Color.FromArgb(211, 163, 251));
            ColorList.Add(Color.FromArgb(191, 246, 253));
            ColorList.Add(Color.FromArgb(255, 171, 171));
            ColorList.Add(Color.FromArgb(247, 255, 93));
            ColorList.Add(Color.FromArgb(255, 129, 129));
            ColorList.Add(Color.FromArgb(217, 217, 217));
        }
        
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            importExcel();
        }

        private void importExcel()
        {
            //if (__mpn_ime.Count == 0)
            if (mpn_ime.Count == 0)
            {
                MessageBox.Show(LogString);
            }
            else
            {
                dgItems.Rows.Clear();
                matchingItemCount = 0;
                lblMatchingProductCount.Text = matchingItemCount.ToString();
                List<ExcelItem> Ham_MPN_Listesi = new List<ExcelItem>();
                List<string> Donusturulmus_MPN_Listesi = new List<string>();
                List<MPN> result = new List<MPN>();


                if (ChooseFile(Ham_MPN_Listesi))
                {
                    foreach (ExcelItem mpn in Ham_MPN_Listesi)
                    {
                        Donusturulmus_MPN_Listesi.Add(RemoveIgnoredCharacters(mpn.MPN).ToUpper());
                    }

                    List<ExcelItem> urun_bulunan_mpnler = new List<ExcelItem>();
                    foreach (string mpn in Donusturulmus_MPN_Listesi)
                    {
                        string tempMPN = mpn.ToString();
                        _tempMPN = tempMPN;
                        removedWordCount = 0;
                        List<string> b = MPN_Listesi.Where(x => x != null && x.Contains(tempMPN)).ToList();

                        if (b.Count() > 0)
                        {
                            int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x.Contains(tempMPN));
                            _tempMPN = tempMPN;

                            urun_bulunan_mpnler.Add(Ham_MPN_Listesi[ham_mpn_indexi]);
                        }
                        else
                        {
                            SearchItemWithMPN_InsertIntoFoundMPNs(tempMPN, b, Donusturulmus_MPN_Listesi, urun_bulunan_mpnler, Ham_MPN_Listesi);
                        }

                        //Bulunan ilk MPN'i değil, eşleşme olan tüm MPN'ler getirilmeli
                        var a = MPN_Listesi.Where(x => x != null && x.Contains(_tempMPN)).ToList();


                        if (a.Count > 0)
                        {
                            foreach (string item in a)
                            {
                                int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x == mpn);
                                int index_a = MPN_Listesi.FindIndex(x => x == item);
                                //string __mpn = __mpn_ime[index_a].Key.ToString();
                                string __mpn = mpn_ime[index_a].ToString();
                                List<CompleteItems_v2> mpn_bulunan_urunler = db.CompleteItems_v2.Where(x => x.MPN == __mpn).ToList();

                                MPN _mpn = new MPN();
                                _mpn.LineNo = ham_mpn_indexi + 1;
                                _mpn.customerMPN = Ham_MPN_Listesi[ham_mpn_indexi].MPN;
                                _mpn.customerQuantity = Ham_MPN_Listesi[ham_mpn_indexi].Quantity;
                                _mpn.items = mpn_bulunan_urunler.ToList();
                                result.Add(_mpn);
                            }
                        }
                        else
                        {
                            int ham_mpn_indexi = Donusturulmus_MPN_Listesi.FindIndex(x => x == mpn);
                            MPN m = new MPN();
                            m.LineNo = ham_mpn_indexi + 1;
                            m.customerMPN = Ham_MPN_Listesi[ham_mpn_indexi].MPN;
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
                                x.customerQuantity = item.customerQuantity;
                                x.item = i;

                                items.Add(x);
                            }
                        }
                        else
                        {
                            _Item x = new _Item();
                            x.LineNo = item.LineNo;
                            x.customerMPN = item.customerMPN;
                            x.customerQuantity = item.customerQuantity;
                            x.item = null;

                            items.Add(x);
                        }

                    }

                    string mpn_ = String.Empty;
                    foreach (_Item item in items)
                    {
                        ItemDetailFill_Row(item);
                        if (mpn_ != item.customerMPN && item.item != null)
                        {
                            matchingItemCount++;
                        }
                        mpn_ = item.customerMPN;
                    }
                    lblMatchingProductCount.Text = matchingItemCount.ToString();

                    string temp = String.Empty;
                    Color c = new Color();
                    foreach (DataGridViewRow row in dgItems.Rows)
                    {
                        if (temp != row.Cells[dgMPN.Index].Value.ToString())
                        {
                            temp = row.Cells[dgMPN.Index].Value.ToString();
                            //c = Color.FromArgb((100 + rnd.Next(128)), (100 + rnd.Next(128)), (100 + rnd.Next(128)));
                            c = ColorList[Convert.ToInt32(row.Cells[dgNo.Index].Value) % 10];
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
        
        void SearchItemWithMPN_InsertIntoFoundMPNs(string tempMPN, List<string> list, List<string> convertedMpnList, List<ExcelItem> ItemFoundMPNs, List<ExcelItem> RawMPNList)
        {
            if (tempMPN.Length >= 8 & removedWordCount < 4)
            {
                tempMPN = tempMPN.Substring(0, tempMPN.Length - 2);
                removedWordCount += 2;
                list = MPN_Listesi.Where(x => x != null && x.Contains(tempMPN)).ToList();
                if (list.Count() > 0)
                {
                    int ham_mpn_indexi = convertedMpnList.FindIndex(x => x.Contains(tempMPN));

                    ItemFoundMPNs.Add(RawMPNList[ham_mpn_indexi]);
                    _tempMPN = tempMPN;
                }
                else
                {
                    SearchItemWithMPN_InsertIntoFoundMPNs(tempMPN, list, convertedMpnList, ItemFoundMPNs, RawMPNList);
                }
            }
        }

        private void GetAllItems()
        {
            string[] lines = new string[0];
            try
            {
                lines = System.IO.File.ReadAllLines("C:\\Program Files\\GenarSoft\\ItemSubtracter\\MPNList.txt");

                foreach (string item in lines)
                {
                    if (item != "")
                    {
                        mpn_ime.Add(item);
                    }
                    else
                    {
                        mpn_ime.Add(null);
                    }
                }

                foreach (var item in mpn_ime)
                {
                    if (item != null)
                    {
                        MPN_Listesi.Add(RemoveIgnoredCharacters(item).ToUpper());
                    }
                    else
                    {
                        MPN_Listesi.Add(null);
                    }
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                LogString = "'Yerel Disk C' içeriside 'MPNList.txt' bulunamadı!";
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

        private bool ChooseFile(List<ExcelItem> Ham_MPN_Listesi)
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
                    object qty = ws.Cells[i, 2].Value;
                    Ham_MPN_Listesi.Add(new ExcelItem { MPN = text, Quantity = Convert.ToDecimal(qty) });
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
            row.Cells[dgCustomerQuantity.Index].Value = rowItem.customerQuantity;
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


            CalculateQuantityIntoRow(rowItem, row);
            //row.Cells[dgColBreak1.Index].Value = rowItem.item?.Col1Break;
            //row.Cells[dgPrice1.Index].Value = rowItem.item?.Col1Price;
            //row.Cells[dgColBreak2.Index].Value = rowItem.item?.Col2Break;
            //row.Cells[dgPrice2.Index].Value = rowItem.item?.Col2Price;
            row.Cells[dgMHCodeLevel1.Index].Value = rowItem.item?.MH_Code_Level_1;
        }

        private void CalculateQuantityIntoRow(_Item item, DataGridViewRow row)
        {
            CompleteItems_v2 i = item.item;
            if (i != null)
            {
                if(item.customerQuantity < i.Col1Break || i.Col1Break == 0)
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col1Break;
                    row.Cells[dgPrice1.Index].Value = i.Col1Price;

                    row.Cells[dgColBreak2.Index].Value = i.Col2Break;
                    row.Cells[dgPrice2.Index].Value = i.Col2Price;
                }
                else if (item.customerQuantity >= i.Col1Break && (item.customerQuantity < i.Col2Break || i.Col2Break == 0))
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col1Break;
                    row.Cells[dgPrice1.Index].Value = i.Col1Price;

                    row.Cells[dgColBreak2.Index].Value = i.Col2Break;
                    row.Cells[dgPrice2.Index].Value = i.Col2Price;
                }
                else if (item.customerQuantity >= i.Col2Break && (item.customerQuantity < i.Col3Break || i.Col3Break == 0))
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col2Break;
                    row.Cells[dgPrice1.Index].Value = i.Col2Price;

                    row.Cells[dgColBreak2.Index].Value = i.Col3Break;
                    row.Cells[dgPrice2.Index].Value = i.Col3Price;
                }
                else if (item.customerQuantity >= i.Col3Break && (item.customerQuantity < i.Col4Break || i.Col4Break == 0))
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col3Break;
                    row.Cells[dgPrice1.Index].Value = i.Col3Price;

                    row.Cells[dgColBreak2.Index].Value = i.Col4Break;
                    row.Cells[dgPrice2.Index].Value = i.Col4Price;
                }
                else if (item.customerQuantity >= i.Col4Break && (item.customerQuantity < i.Col5Break || i.Col5Break == 0))
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col4Break;
                    row.Cells[dgPrice1.Index].Value = i.Col4Price;

                    row.Cells[dgColBreak2.Index].Value = i.Col5Break;
                    row.Cells[dgPrice2.Index].Value = i.Col5Price;
                }
                else if (item.customerQuantity >= i.Col5Break)
                {
                    row.Cells[dgColBreak1.Index].Value = i.Col5Break;
                    row.Cells[dgPrice1.Index].Value = i.Col5Price;

                    row.Cells[dgColBreak2.Index].Value = "--";
                    row.Cells[dgPrice2.Index].Value = "--";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogString = "Yükleniyor";
            label1.Text = LogString;
            label1.ForeColor = Color.MidnightBlue;
            this.Refresh();
            try
            {
                pb_ProgressCircle.Visible = true;
                bw_TakeMPNList.RunWorkerAsync();
                button1.Visible = false;
            }
            catch (Exception ex)
            {
                LogString = "Liste Yüklenemedi!";
                label1.Text = LogString;
                label1.ForeColor = Color.Red;
                //__mpn_ime = new List<IGrouping<string, MPN_List>>();
                mpn_ime = new List<string>();
            }
        }

        private void bw_TakeMPNList_DoWork(object sender, DoWorkEventArgs e)
        {
            GetAllItems();
        }

        private void bw_TakeMPNList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LogString = "Liste Hazır";
            label1.Text = LogString;
            label1.ForeColor = Color.Green;
            pb_ProgressCircle.Visible = false;
        }
        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var list = db.MPN_List.GroupBy(x => x.MPN).ToList();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\MPNList.txt"))
            {
                foreach (var item in list)
                {
                    if (item.Key != null)
                    {
                        file.WriteLine(item.Key);
                    }
                    else
                    {
                        file.WriteLine("");
                    }
                }
            }
        }

        private void bw_ItemAnalyzer_DoWork(object sender, DoWorkEventArgs e)
        {
            importExcel();
        }
    }

    class MPN
    {
        public int LineNo { get; set; }
        public string customerMPN { get; set; }
        public decimal customerQuantity { get; set; }
        public List<CompleteItems_v2> items { get; set; }
    }

    class _Item
    {
        public int LineNo { get; set; }
        public string customerMPN { get; set; }
        public decimal customerQuantity { get; set; }
        public CompleteItems_v2 item { get; set; }
    }

    class ExcelItem
    {
        public string MPN { get; set; }
        public decimal Quantity { get; set; }
    }
}
