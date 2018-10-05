using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_Subtracter.Helpers
{
    class Utils
    {
        public static void ExportDataGridToExcel(DataGridView Grid, string FileName)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = Excel.ActiveSheet;

            for (int i = 1; i < Grid.ColumnCount + 1; i++)
            {
                ws.Cells[1, i].NumberFormat = "@";
                ws.Cells[1, i] = Grid.Columns[i-1].HeaderText;
            }
            ws.Cells[1, 1].EntireRow.Font.Bold = true;

            int rowIndex = 2;
            for (int i = 2; i < Grid.RowCount + 2; i++)
            {
                if (Grid.Rows[i - 2].Cells[0].Value != null && (bool)Grid.Rows[i-2].Cells[0].Value == true)
                {
                    for (int j = 1; j < Grid.ColumnCount + 1; j++)
                    {
                        DataGridViewCell cell = Grid.Rows[i - 2].Cells[j-1];
                        ws.Cells[rowIndex, j].NumberFormat = "@";
                        if (!String.IsNullOrEmpty(cell.Value?.ToString()))
                        {
                            ws.Cells[rowIndex, j] = cell.Value.ToString();
                        }
                        else
                        {
                            ws.Cells[rowIndex, j] = String.Empty;
                        }

                        ws.Cells[rowIndex, j].Interior.Color = cell.OwningRow.DefaultCellStyle.BackColor;
                    }
                    rowIndex++;
                }
            }

            ws.UsedRange.Columns.AutoFit();
            Excel.Visible = true;

            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.Filter = "Excel Files (*.xls)|*.xls|All files (*.xls)|*.xls";
            //savefile.FileName = FileName;

            //object misValue = System.Reflection.Missing.Value;
            //if (savefile.ShowDialog() == DialogResult.OK)
            //{
            //    string path = savefile.FileName;
            //    //@"C:\Users\PC\Desktop\test2.xls"
            //    wb.SaveAs(@path, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //}
        }
    }
}
