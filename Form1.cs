using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // 給予每一個輸入文字框一個「空字串」
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douM * 100);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM * 100 / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douM * 100 / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douM * 100 / 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text);
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
                txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douKM * 100000 / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douKM * 100000 / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douKM * 100000 / 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;

            douIn = Convert.ToDouble(txtIn.Text);
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douIn * 2.54 / 100);
                txtKM.Text = string.Format("{0:0.##########}", douIn * 2.54 / 100000);
                txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
                txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;

            douFt = Convert.ToDouble(txtFt.Text);
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douFt * 30.48 / 100);
                txtKM.Text = string.Format("{0:0.##########}", douFt * 30.48 / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
                txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;

            douYard = Convert.ToDouble(txtYard.Text);
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douYard * 91.44 / 100);
                txtKM.Text = string.Format("{0:0.##########}", douYard * 91.44 / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
                txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }
    }
}
         
    

