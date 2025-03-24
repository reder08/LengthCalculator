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
      
        string strInput; 
        double douOutput; 

        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtCM.Text; 

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

            // 給予每一個輸入文字框一個「空字串」
        private void txtM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtM.Text; 

           
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtKM.Text; // txtKM

           
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 10000);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, EventArgs e)
        {
            strInput = txtIn.Text; // txtIn

            
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, EventArgs e)
        {
            strInput = txtFt.Text; // txtFt

            
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, EventArgs e)
        {
            strInput = txtYard.Text; // txtFt

            
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
               
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";
        }

       
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
    }
}
