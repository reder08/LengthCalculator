﻿using System;
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

        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
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
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);

            txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
            txtIn.Text = string.Format("{0:0.##########}", douM * 100 / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douM * 100 / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douM * 100 / 91.44);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text); 

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000); 

            txtM.Text = string.Format("{0:0.##########}", douKM * 1000); 
            txtIn.Text = string.Format("{0:0.##########}", douKM * 100000 / 2.54); 
            txtFt.Text = string.Format("{0:0.##########}", douKM * 100000 / 30.48); 
            txtYard.Text = string.Format("{0:0.##########}", douKM * 100000 / 91.44); 
        }
    }
}
