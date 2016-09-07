using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    
    public partial class Form1 : Form
    {
        Excel.Application _Excel = null;
        int nowrow = 1;
        Excel.Workbook book = null;
        Excel.Worksheet sheet = null;
        Excel.Range range = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = accdate.Text;
            label1.Text += acctype.Text;
            label1.Text += accmoney.Text;
            label1.Text += accsp.Text;
            range = sheet.get_Range("A" + nowrow.ToString());
            range.set_Value(Type.Missing, accdate.Text);
            range = sheet.get_Range("B" + nowrow.ToString());
            range.set_Value(Type.Missing, acctype.Text);
            range = sheet.get_Range("C" + nowrow.ToString());
            range.set_Value(Type.Missing, accmoney.Text);
            range = sheet.get_Range("D" + nowrow.ToString());
            range.set_Value(Type.Missing, accsp.Text);
            nowrow += 1;
            this.accdate.Focus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //全選
            accmoney.GotFocus += (object sender1, EventArgs e1) =>
                {
                    accmoney.SelectAll();
                };
            accsp.GotFocus += (object sender2, EventArgs e2) =>
            {
                accsp.SelectAll();
            };

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            sheet.Application.DisplayAlerts = false;
            sheet.Application.AlertBeforeOverwriting = false;
            book.Save();

            book.Close();
            this._Excel.Quit();
            this._Excel = null;
            //確認已經沒有excel工作再回收
            GC.Collect();
            label2.Text = "CLOSE";
        }

        private void accopen_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var item in Process.GetProcesses())
            {
                if (item.ProcessName == "EXCEL")
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                this._Excel = new Excel.Application();
            }
            else
            {
                object obj = Marshal.GetActiveObject("Excel.Application");//引用已在執行的Excel
                _Excel = obj as Excel.Application;
            }

            this._Excel.Visible = true;//設false效能會比較好


            string path = "E:\\accounttemp.xlsx";

            book = _Excel.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);//開啟舊檔案
            sheet = (Excel.Worksheet)book.Sheets[1];

            range = sheet.get_Range("A" + nowrow.ToString());
            string temptext = range.Cells.Text;
            while (temptext != "")
            {
                nowrow += 1;
                label1.Text += range.Cells.Text;
                range = sheet.get_Range("A" + nowrow.ToString());
                temptext = range.Cells.Text;
            }



            //foreach (Excel.Range item in range)
            //{
            //    //Console.WriteLine(item.Cells.Formula);
            //    //Console.WriteLine(item.Cells.Value2);
            //    //Console.WriteLine(item.Cells.Text);
            //    label1.Text += item.Cells.Formula;
            //    label1.Text += item.Cells.Value2;
            //    label1.Text += item.Cells.Text;
            //}

            label2.Text = "OPENING";
        }
    }
}
