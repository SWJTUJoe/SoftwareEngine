using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 上机实习二
{
    public partial class 角度转换 : Form
    {
        public 角度转换()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//度分秒转十进制
        {
            Data Result = new Data();
            Result.Degree = Convert.ToDouble(textBox12.Text);
            Result.Minute = Convert.ToDouble(textBox10.Text);
            Result.Second = Convert.ToDouble(textBox6.Text);
            if (Result.Minute > 60 || Result.Second > 60)
            {
                MessageBox.Show("角度输入不正确", "提示", MessageBoxButtons.OK);
                交会计算.ClearCntrValue(this.tabControl1);
            }
            else
                textBox11.Text = Convert.ToString(Base_Calculation.function3(Result));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button6_Click(object sender, EventArgs e)//十进制转度分秒
        {
            Data Result = new Data();
            Result.Angle = Convert.ToDouble(textBox5.Text);
            Result = Base_Calculation.function4(Result);
            textBox9.Text = Convert.ToString(Result .Degree);
            textBox8.Text = Convert.ToString(Result.Minute);
            textBox7.Text = Convert.ToString(Result.Second);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button12_Click(object sender, EventArgs e)//度分秒转弧度
        {
            Data Result = new Data();
            Result.Degree = Convert.ToDouble(textBox20.Text);
            Result.Minute = Convert.ToDouble(textBox18.Text);
            Result.Second = Convert.ToDouble(textBox17.Text);
            if (Result.Minute > 60 || Result.Second > 60)
            {
                MessageBox.Show("角度输入不正确", "提示", MessageBoxButtons.OK);
                交会计算.ClearCntrValue(this.tabControl1);
            }
            else
                textBox19.Text = Convert.ToString(Base_Calculation.function5(Result));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button10_Click(object sender, EventArgs e)//弧度转度分秒
        {
            Data Result = new Data();
            Result.Angle = Convert.ToDouble(textBox16.Text);
            Result = Base_Calculation.function6(Result);
            textBox15.Text = Convert.ToString(Result.Degree);
            textBox14.Text = Convert.ToString(Result.Minute);
            textBox13.Text = Convert.ToString(Result.Second);
        }

        private void button1_Click_1(object sender, EventArgs e)//弧度转十进制
        {
            Data Result = new Data();
            Result.Angle = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(Base_Calculation.function1(Result));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button3_Click_1(object sender, EventArgs e)//十进制转弧度
        {
            Data Result = new Data();
            Result.Angle = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(Base_Calculation.function2(Result));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其角度{0}°{1}′{2}″转换成十进制为：{3}", textBox12.Text, textBox10.Text, textBox6.Text, textBox11.Text);
            sw.Close();
            fs.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其十进制{0}转换成度分秒为：{1}°{2}′{3}″", textBox5.Text, textBox9.Text, textBox8.Text, textBox7.Text);
            sw.Close();
            fs.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其角度{0}°{1}′{2}″转换成弧度制为：{3}", textBox20.Text, textBox18.Text, textBox17.Text, textBox19.Text);
            sw.Close();
            fs.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其弧度制{0}转换成度分秒为：{1}°{2}′{3}″", textBox16.Text, textBox15.Text, textBox14.Text, textBox13.Text);
            sw.Close();
            fs.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其弧度制{0}转换十进制为：{1}°", textBox1.Text, textBox2.Text);
            sw.Close();
            fs.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("其十进制{0}转换弧度制为：{1}°", textBox3.Text, textBox4.Text);
            sw.Close();
            fs.Close();
        }
    }
}
