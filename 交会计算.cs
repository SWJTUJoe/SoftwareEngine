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
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace 上机实习二
{
    public partial class 交会计算 : Form
    {

       
        public 交会计算()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//前方交会
        {
            Data pointA = new Data();
            Data pointB = new Data();
            Data Result = new Data();
            Data angleA = new Data();
            Data angleB = new Data();
            pointA.x = Convert.ToDouble(textBox1.Text);
            pointA.y = Convert.ToDouble(textBox2.Text);
            pointB.x = Convert.ToDouble(textBox3.Text);
            pointB.y = Convert.ToDouble(textBox4.Text);
            angleA.Angle = Convert.ToDouble(textBox9.Text);
            angleA.Minute = Convert.ToDouble(textBox5.Text);
            angleA.Second = Convert.ToDouble(textBox6.Text);
            angleB.Angle = Convert.ToDouble(textBox12.Text);
            angleB.Minute = Convert.ToDouble(textBox11.Text);
            angleB.Second = Convert.ToDouble(textBox10.Text);
            Forward_Inter obj = new Forward_Inter();
            Result = obj.Cross_Cal(pointA, pointB, angleA, angleB);
            textBox8.Text = Convert.ToString(Result.x);
            textBox7.Text = Convert.ToString(Result.y);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            ClearCntrValue(this.tabControl1);
        }
       

        private void button4_Click(object sender, EventArgs e)//后方交会
        {
            Data pointA = new Data();
            Data pointB = new Data();
            Data pointC = new Data();
            Data Result = new Data();
            Data angleA = new Data();
            Data angleB = new Data();
            Data angleC = new Data();
            pointA.x = Convert.ToDouble(textBox29.Text);
            pointA.y = Convert.ToDouble(textBox28.Text);
            pointB.x = Convert.ToDouble(textBox27.Text);
            pointB.y = Convert.ToDouble(textBox26.Text);
            pointC.x = Convert.ToDouble(textBox25.Text);
            pointC.y = Convert.ToDouble(textBox24.Text);
            angleA.Angle = Convert.ToDouble(textBox21.Text);
            angleA.Minute = Convert.ToDouble(textBox20.Text);
            angleA.Second = Convert.ToDouble(textBox19.Text);
            angleB.Angle = Convert.ToDouble(textBox18.Text);
            angleB.Minute = Convert.ToDouble(textBox14.Text);
            angleB.Second = Convert.ToDouble(textBox13.Text);
            angleC.Angle = Convert.ToDouble(textBox17.Text);
            angleC.Minute = Convert.ToDouble(textBox16.Text);
            angleC.Second = Convert.ToDouble(textBox15.Text);
            Resection obj = new Resection();
            Result = obj.Cross_Cal1(pointA, pointB, pointC, angleA, angleB, angleC);
            textBox23.Text = Convert.ToString(Result.x);
            textBox22.Text = Convert.ToString(Result.y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearCntrValue(this.tabControl1);
        }

        private void button6_Click(object sender, EventArgs e)//距离交会
        {
            Data pointA = new Data();
            Data pointB = new Data();
            Data L1 = new Data();
            Data L2 = new Data();
            Data Result = new Data();
            pointA.x = Convert.ToDouble(textBox37.Text);
            pointA.y = Convert.ToDouble(textBox36.Text);
            pointB.x = Convert.ToDouble(textBox35.Text);
            pointB.y = Convert.ToDouble(textBox34.Text);
            L1.Distance = Convert.ToDouble(textBox31.Text);
            L2.Distance = Convert.ToDouble(textBox30.Text);
            Dis_Rendezvous obj = new Dis_Rendezvous();
            Result = obj.Cross_Cal(pointA, pointB, L1, L2);
            textBox33.Text = Convert.ToString(Result.x);
            textBox32.Text = Convert.ToString(Result.y);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearCntrValue(this.tabControl1);
        }

        private void button8_Click(object sender, EventArgs e)//侧方交会
        {
            Data pointA = new Data();
            Data pointB = new Data();
            Data Result = new Data();
            Data angleA = new Data();
            Data angleB = new Data();
            pointA.x = Convert.ToDouble(textBox40.Text);
            pointA.y = Convert.ToDouble(textBox41.Text);
            pointB.x = Convert.ToDouble(textBox39.Text);
            pointB.y = Convert.ToDouble(textBox38.Text);
            angleA.Angle = Convert.ToDouble(textBox47.Text);
            angleA.Minute = Convert.ToDouble(textBox46.Text);
            angleA.Second = Convert.ToDouble(textBox45.Text);
            angleB.Angle = Convert.ToDouble(textBox44.Text);
            angleB.Minute = Convert.ToDouble(textBox43.Text);
            angleB.Second = Convert.ToDouble(textBox42.Text);
            Side_intersection obj = new Side_intersection();
            Result = obj.Cross_Cal(pointA, pointB, angleA, angleB);
            textBox49.Text = Convert.ToString(Result.x);
            textBox48.Text = Convert.ToString(Result.y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearCntrValue(this.tabControl1);
        }
        public static void ClearCntrValue(Control parContainer)//清除工具

        {

            for (int index = 0; index < parContainer.Controls.Count; index++)

            {

                // 如果是容器类控件，递归调用自己

                if (parContainer.Controls[index].HasChildren)

                {

                    ClearCntrValue(parContainer.Controls[index]);

                }

                else

                {

                    switch (parContainer.Controls[index].GetType().Name)

                    {

                        case "TextBox":

                            parContainer.Controls[index].Text = "";

                            break;

                        case "RadioButton":

                            ((RadioButton)(parContainer.Controls[index])).Checked = false;

                            break;

                        case "CheckBox":

                            ((CheckBox)(parContainer.Controls[index])).Checked = false;

                            break;

                        case "ComboBox":

                            ((ComboBox)(parContainer.Controls[index])).Text = "";

                            break;
                        case "RichTextBox":

                            ((RichTextBox)(parContainer.Controls[index])).Text = "";

                            break;

                    }

                }

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("侧方交会得出的坐标为：{0}m,{1}m", textBox49.Text, textBox48.Text);
            sw.Close();
            fs.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("前方交会得出的坐标为：{0}m,{1}m", textBox8.Text, textBox7.Text); 
            sw.Close();
            fs.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("距离交会得出的坐标为：{0}m,{1}m", textBox33.Text, textBox32.Text);
            sw.Close();
            fs.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("后方交会得出的坐标为：{0}m,{1}m", textBox23.Text, textBox22.Text);
            sw.Close();
            fs.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Angle = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox1.Text);
            Point1.P_y = Convert.ToDecimal(textBox2.Text);
            Point2.P_x = Convert.ToDecimal(textBox3.Text);
            Point2.P_y = Convert.ToDecimal(textBox4.Text);
            Result.x = Convert.ToDouble(textBox8.Text);
            Result.y = Convert.ToDouble(textBox7.Text);
            Angle.A_Result = Convert.ToString(textBox9.Text) + "°" + Convert.ToString(textBox5.Text) + "′" + Convert.ToString(textBox6.Text) + "″";
            Angle.B_Result = Convert.ToString(textBox12.Text) + "°" + Convert.ToString(textBox11.Text) + "′" + Convert.ToString(textBox10.Text) + "″";
           
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO  Forward_Inter(Point1_x,Point1_y,Point2_x,Point2_y, Angle_A ,Angle_B ,Result_x ,Result_y) VALUES(" + Point1.P_x + ", " + Point1.P_y + "," + Point2.P_x + ", " + Point2.P_y + ",'" + (Angle.A_Result) + "','" + (Angle.B_Result) + "'," + Result.x + ", " + Result.y + ")";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result = sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Point3 = new Data();
            Data Angle = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox29.Text);
            Point1.P_y = Convert.ToDecimal(textBox28.Text);
            Point2.P_x = Convert.ToDecimal(textBox27.Text);
            Point2.P_y = Convert.ToDecimal(textBox26.Text);
            Point3.P_x = Convert.ToDecimal(textBox25.Text);
            Point3.P_y = Convert.ToDecimal(textBox24.Text);
            Result.x = Convert.ToDouble(textBox23.Text);
            Result.y = Convert.ToDouble(textBox22.Text);
            Angle.A_Result = Convert.ToString(textBox21.Text) + "°" + Convert.ToString(textBox20.Text) + "′" + Convert.ToString(textBox19.Text) + "″";
            Angle.B_Result = Convert.ToString(textBox18.Text) + "°" + Convert.ToString(textBox14.Text) + "′" + Convert.ToString(textBox13.Text) + "″";
            Angle.C_Result = Convert.ToString(textBox17.Text) + "°" + Convert.ToString(textBox16.Text) + "′" + Convert.ToString(textBox15.Text) + "″";

            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO  Resection(Point1_x,Point1_y,Point2_x,Point2_y,Point3_x,Point3_y, Angle_A ,Angle_B ,Angle_C,Result_x ,Result_y) VALUES" +
                "(" + Point1.P_x + ", " + Point1.P_y + "," + Point2.P_x + ", " + Point2.P_y + "," + Point3.P_x + ", " + Point3.P_y + ",'" + (Angle.A_Result) + "'," +
                "'" + (Angle.B_Result) + "','" + (Angle.C_Result) + "'," + Result.x + ", " + Result.y + ")";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result = sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Dis_A = new Data();
            Data Dis_B = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox37.Text);
            Point1.P_y = Convert.ToDecimal(textBox36.Text);
            Point2.P_x = Convert.ToDecimal(textBox35.Text);
            Point2.P_y = Convert.ToDecimal(textBox34.Text);
            Result.x = Convert.ToDouble(textBox33.Text);
            Result.y = Convert.ToDouble(textBox32.Text);
            Dis_A.Distance = Convert.ToDouble(textBox31.Text);
            Dis_B.Distance = Convert.ToDouble(textBox30.Text);

            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO Dis_Rendezvous(Point1_x,Point1_y,Point2_x,Point2_y,Distance_A ,Distance_B ,Result_x ,Result_y) VALUES" +
                "(" + Point1.P_x + ", " + Point1.P_y + "," + Point2.P_x + ", " + Point2.P_y + ",'" + Dis_A.Distance + "','" + Dis_B.Distance + "'," + Result.x + ", " + Result.y + ")";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result = sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Angle = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox41.Text);
            Point1.P_y = Convert.ToDecimal(textBox40.Text);
            Point2.P_x = Convert.ToDecimal(textBox39.Text);
            Point2.P_y = Convert.ToDecimal(textBox38.Text);
            Result.x = Convert.ToDouble(textBox49.Text);
            Result.y = Convert.ToDouble(textBox48.Text);
            Angle.A_Result = Convert.ToString(textBox47.Text) + "°" + Convert.ToString(textBox46.Text) + "′" + Convert.ToString(textBox45.Text) + "″";
            Angle.B_Result = Convert.ToString(textBox44.Text) + "°" + Convert.ToString(textBox43.Text) + "′" + Convert.ToString(textBox42.Text) + "″";

            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO  Side_intersection(Point1_x,Point1_y,Point2_x,Point2_y, Angle_A ,Angle_B ,Result_x ,Result_y) VALUES(" + Point1.P_x + ", " + Point1.P_y + "," + Point2.P_x + ", " + Point2.P_y + ",'" + (Angle.A_Result) + "','" + (Angle.B_Result) + "'," + Result.x + ", " + Result.y + ")";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result = sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Data PointA = new Data();//创建对象
            Data PointB = new Data();          
            Data Result = new Data();
            Data Mid = new Data();
            Data Change = new Data();
            Data SysX = new Data();
            Data SysY = new Data();
            Data Re = new Data();
            
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);//创建 Bitmap对象
            Graphics G = pictureBox1.CreateGraphics();//在picture上绘制
            G = Graphics.FromImage(bitmap);
            SolidBrush Backgro = new SolidBrush(Color.White);
            G.FillRectangle(Backgro, 0, 0, pictureBox1.Width, pictureBox1.Height);//背景白色
            Pen pen = new Pen(Color.Red);//定义画笔

            PointA.x = Convert.ToDouble(textBox1.Text);//获取坐标
            PointA.y = Convert.ToDouble(textBox2.Text);
            PointB.x = Convert.ToDouble(textBox3.Text);
            PointB.y = Convert.ToDouble(textBox4.Text);
            Result.x= Convert.ToDouble(textBox8.Text); 
            Result.y= Convert.ToDouble(textBox7.Text);
            string PoA = "A(" + textBox1.Text + "," + textBox2.Text + ")";
            string PoB = "B(" + textBox3.Text + "," + textBox4.Text + ")";
            string PoC = "C(" + textBox8.Text + "," + textBox7.Text + ")";

            double a = Math.Abs(PointA.x - PointB.x);
            if (a < Math.Abs(PointA.x - Result.x))
                a = Math.Abs(PointA.x - Result.x);
            if (a < Math.Abs(PointB.x - Result.x))
                a = Math.Abs(PointB.x - Result.x);
            if (a < Math.Abs(PointA.y - PointB.y))
                a = Math.Abs(PointA.y - PointB.y);
            if (a < Math.Abs(PointA.y - Result.y))
                a = Math.Abs(PointA.y - Result.y);
            if (a < Math.Abs(PointB.y - Result.y))
                a = Math.Abs(PointB.y - Result.y);//求坐标之差的最大值，用于缩放图形

            PointA.x = PointA.x* pictureBox1.Size.Height / 1.5 / a;
            PointA.y = PointA.y * pictureBox1.Size.Height / 1.5 / a;
            PointB.x = PointB.x * pictureBox1.Size.Height / 1.5 / a;
            PointB.y = PointB.y * pictureBox1.Size.Height / 1.5 / a;
            Result.x = Result.x * pictureBox1.Size.Height / 1.5 / a;
            Result.y = Result.y * pictureBox1.Size.Height / 1.5 / a;//放缩图形，适应窗口

            Change.x = (PointA.x + PointB.x + Result.x) / 3;
            Change.y = (PointA.y + PointB.y + Result.y) / 3;

            Mid.x = Change.x - pictureBox1.Size.Height / 2;//计算图形中点到容器中点的距离，为了使图像居中。
            Mid.y = Change.y - pictureBox1.Size.Width / 2;

            SysX.y = pictureBox1.Size.Height - (PointA.x - Mid.x);//使图像居中,并变换坐标系。
            SysX.x = (PointA.y - Mid.y);
            SysY.y = pictureBox1.Size.Height - (PointB.x - Mid.x);
            SysY.x= (PointB.y - Mid.y);
            //坐标系转换
            Re.x = (Result.y - Mid.y);
            Re.y = pictureBox1.Size.Height - (Result.x - Mid.x);
           
            PointF point1 = new PointF((float)(SysX.x), (float)(SysX.y));
            PointF point2 = new PointF((float)(SysY.x), (float)(SysY.y));
            PointF point3 = new PointF((float)(Re.x), (float)(Re.y));
            PointF[] pointGather = new PointF[] { point1, point2, point3 };
            LinearGradientBrush br = new LinearGradientBrush(point1, point2, Color.Red, Color.Purple);
            G.FillPolygon(br, pointGather);//填充三角形
            Font ft1 = new Font("宋体", 10);//标计点信息
            Font ft2 = new Font("宋体", 10);
            Font ft3 = new Font("黑体", 10);

            G.DrawLine(pen, point1, point2);//绘制三角形
            G.DrawLine(pen, point1, point3);
            G.DrawLine(pen, point2, point3);

            G.DrawString("已知点:"+PoA, ft1, Brushes.Coral, point1);//绘制点信息
            G.DrawString("已知点:"+PoB, ft2, Brushes.Coral, point2);
            G.DrawString("待求点:"+PoC, ft3, Brushes.Black, point3);

       
            pictureBox1.Image = bitmap;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            

           





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}





            




