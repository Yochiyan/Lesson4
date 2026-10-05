using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void solve_Click(object sender, EventArgs e)
        {
            //身長・体重を・BMIを記録する変数を定義する
            double height, weight, BMI;
            //stringである身長・体重をdouble型に変換する
            height = double.Parse(HeightBox.Text);
            weight = double.Parse(WeightBox.Text);
            //BMIを計算する
            BMI = weight / (height* height);
            //BMIを表示する
           
            BMINum.Text = BMI.ToString();

            if (BMI < 18.5)
            {
                Result.Text = "あなたは痩せすぎです。";
                return;
            }
            if (BMI > 25)
            {
                Result.Text = "あなたは太りすぎです。";
                return;
                }
            Result.Text = "あなたは標準の範囲内です。";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            WeightBox.Text = "";
            HeightBox.Text = "";
            Result.Text = "";
            BMINum.Text = "";
        }
    }
}
