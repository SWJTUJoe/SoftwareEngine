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
    public partial class 矩阵计算 : Form
    {
        public 矩阵计算()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//矩阵加法
        {
            string matrix = "";//定义一matrix的字符型变量
            double[,] mat1;//定义一个矩阵
            string[] b = richTextBox1.Lines[1].Split(' ');//建第一列的数组
            mat1 = new double[richTextBox1.Lines.Length, b.Length];//字符转矩阵
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string[] mat2 = richTextBox1.Lines[i].Split(' ');
                for (int j = 0; j < mat2.Length; j++)
                {
                    mat1[i, j] = double.Parse(mat2[j]);
                }
            }
            double[,] mat3;
            string[] c = richTextBox2.Lines[1].Split(' ');
            mat3 = new double[richTextBox2.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox2.Lines.Length; i++)
            {
                string[] mat4 = richTextBox2.Lines[i].Split(' ');
                for (int j = 0; j < mat4.Length; j++)
                {
                    mat3[i, j] = double.Parse(mat4[j]);
                }
            }
            double[,] C = Matrixcomputation.Add(mat1, mat3);
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (j == (C.GetLength(1)-1))
                    { matrix = matrix + Convert.ToString(C[i, j]); }
                    else matrix = matrix + Convert.ToString(C[i, j]) + ","; ;
                }
                matrix = matrix + "\r\n";
            }
            richTextBox3.Text = matrix.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button3_Click(object sender, EventArgs e)//矩阵减法
        {
            string matrix = "";
            double[,] mat1;
            string[] b = richTextBox6.Lines[1].Split(' ');
            mat1 = new double[richTextBox6.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox6.Lines.Length; i++)
            {
                string[] mat2 = richTextBox6.Lines[i].Split(' ');
                for (int j = 0; j < mat2.Length; j++)
                {
                    mat1[i, j] = double.Parse(mat2[j]);
                }
            }
            double[,] mat3;
            string[] c = richTextBox5.Lines[1].Split(' ');
            mat3 = new double[richTextBox5.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox5.Lines.Length; i++)
            {
                string[] mat4 = richTextBox5.Lines[i].Split(' ');
                for (int j = 0; j < mat4.Length; j++)
                {
                    mat3[i, j] = double.Parse(mat4[j]);
                }
            }
            double[,] C = Matrixcomputation.Subtract(mat1, mat3);
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (j == (C.GetLength(1) - 1))
                    { matrix = matrix+ Convert.ToString(C[i, j]); }
                    else matrix = matrix + Convert.ToString(C[i, j]) + " ,"; ;
                    
                }
                matrix = matrix + "\r\n";//换行回车
            }
            richTextBox4.Text = matrix.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button6_Click(object sender, EventArgs e)//矩阵乘法
        {
            string matrix = "";
            double[,] mat1;
            string[] b = richTextBox9.Lines[1].Split(' ');
            mat1 = new double[richTextBox9.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox9.Lines.Length; i++)
            {
                string[] mat2 = richTextBox9.Lines[i].Split(' ');
                for (int j = 0; j < mat2.Length; j++)
                {
                    mat1[i, j] = double.Parse(mat2[j]);
                }
            }
            double[,] mat3;
            string[] c = richTextBox8.Lines[1].Split(' ');
            mat3 = new double[richTextBox8.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox8.Lines.Length; i++)
            {
                string[] mat4 = richTextBox8.Lines[i].Split(' ');
                for (int j = 0; j < mat4.Length; j++)
                {
                    
                    mat3[i, j] = double.Parse(mat4[j]);
                }
            }
            double[,] C = Matrixcomputation.Multiply(mat1, mat3);
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (j == (C.GetLength(1) - 1))
                        matrix = matrix + Convert.ToString(C[i, j]);
                    else matrix = matrix + Convert.ToString(C[i, j]) + ",";
                }
                matrix = matrix + "\r\n";
            }
            richTextBox7.Text = matrix.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button7_Click(object sender, EventArgs e)//矩阵求逆
        {
            string matrix = "";
            double[,] mat1;
            string[] b = richTextBox11.Lines[1].Split(' ');
            mat1 = new double[richTextBox11.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox11.Lines.Length; i++)
            {
                string[] mat2 = richTextBox11.Lines[i].Split(' ');
                for (int j = 0; j < mat2.Length; j++)
                {
                    
                    mat1[i, j] = double.Parse(mat2[j]);
                }
            }

            double[,] C = Matrixcomputation.Inverse(mat1);
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (j == (C.GetLength(1) - 1))
                    { matrix = matrix + Convert.ToString(C[i, j]); }
                    else matrix = matrix + Convert.ToString(C[i, j]) + ","; ;
                }
                matrix = matrix + "\r\n";
            }
            richTextBox10.Text = matrix.ToString();
        }

        private void button8_Click(object sender, EventArgs e)//矩阵转置
        {
            string matrix = "";
            double[,] mat1;
            string[] b = richTextBox13.Lines[1].Split(' ');
            mat1 = new double[richTextBox13.Lines.Length, b.Length];
            for (int i = 0; i < richTextBox13.Lines.Length; i++)
            {
                string[] mat2 = richTextBox13.Lines[i].Split(' ');
                for (int j = 0; j < mat2.Length; j++)
                {
                    mat1[i, j] = double.Parse(mat2[j]);
                }
            }

            double[,] C = Matrixcomputation.Transpose(mat1);
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (j == (C.GetLength(1) - 1))
                    { matrix = matrix + Convert.ToString(C[i, j]); }
                   else matrix = matrix + Convert.ToString(C[i, j]) + ",";
                }
                matrix = matrix + "\r\n";
            }
            richTextBox12.Text = matrix.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }



        

       

        private void button14_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("矩阵加法得出的矩阵为：{0}", richTextBox3.Text);
            sw.Close();
            fs.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("矩阵减法得出的矩阵为：{0}", richTextBox3.Text);
            sw.Close();
            fs.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("矩阵乘法法得出的矩阵为：{0}", richTextBox7.Text);
            sw.Close();
            fs.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("矩阵求逆得出的矩阵为：{0}", richTextBox10.Text);
            sw.Close();
            fs.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("矩阵转置得出的矩阵为：{0}", richTextBox12.Text);
            sw.Close();
            fs.Close();
        }
    }
}
