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

namespace 上机实习二
{
    public partial class 距离与坐标方位角 : Form
    {
        public 距离与坐标方位角()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//距离计算
        {
            Data Point_A = new Data();
            Data Point_B = new Data();
            Point_A.x = Convert.ToDouble(textBox1.Text);
            Point_A.y = Convert.ToDouble(textBox2.Text);
            Point_B.x = Convert.ToDouble(textBox4.Text);
            Point_B.y = Convert.ToDouble(textBox3.Text);
            textBox5.Text = Convert.ToString(Base_Calculation.Distance(Point_A,Point_B));
        }

        private void button4_Click(object sender, EventArgs e)//方位角计算
        {
            Data Point_A = new Data();
            Data Point_B = new Data();
            Data Angle_1 = new Data();
            Point_A.x = Convert.ToDouble(textBox12.Text);
            Point_A.y = Convert.ToDouble(textBox11.Text);
            Point_B.x = Convert.ToDouble(textBox10.Text);
            Point_B.y = Convert.ToDouble(textBox9.Text);
            Angle_1.Angle= Base_Calculation.Angle_cal(Point_A, Point_B);
            Angle_1 = Base_Calculation.function6(Angle_1);
            textBox6.Text = Convert.ToString(Angle_1.Degree);
            textBox8.Text = Convert.ToString(Angle_1 .Minute);
            textBox7.Text = Convert.ToString(Angle_1.Second);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            交会计算.ClearCntrValue(this.tabControl1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("两点之间的距离为：{0}m", textBox5.Text);
            sw.Close();
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("两点之间的方位角为：{0}°{1}′{2}″", textBox6.Text, textBox8.Text, textBox7.Text);
            sw.Close();
            fs.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox1.Text);
            Point1.P_y = Convert.ToDecimal(textBox2.Text);
            Point2.P_x = Convert.ToDecimal(textBox4.Text);
            Point2.P_y= Convert.ToDecimal(textBox3.Text);
            Result.Result = Convert.ToDecimal(textBox5.Text);
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True
";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO Dis_Result(Point1_x,Point1_y,Point2_x,Point2_y,Distance) VALUES(" + Point1.P_x+ ", "+Point1.P_y + ","+Point2.P_x+ ", "+Point2.P_y + ","+ Result.Result + ")";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result=sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Data Point1 = new Data();
            Data Point2 = new Data();
            Data Result = new Data();
            Point1.P_x = Convert.ToDecimal(textBox12.Text);
            Point1.P_y = Convert.ToDecimal(textBox11.Text);
            Point2.P_x = Convert.ToDecimal(textBox10.Text);
            Point2.P_y = Convert.ToDecimal(textBox9.Text);
            Result.A_Result = Convert.ToString(textBox6.Text) + "°"+Convert.ToString(textBox8.Text) +"′"+ Convert.ToString(textBox7.Text)+"″";
          
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            String sql = "INSERT INTO Angle_Result(Point1_x,Point1_y,Point2_x,Point2_y,Angle) VALUES(" + Point1.P_x + ", " + Point1.P_y + "," + Point2.P_x + ", " + Point2.P_y + ",'"+(Result.A_Result)+"')";//SQL语句向表中写入数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int result = sqlCommand.ExecuteNonQuery();
            if (result == 1) { MessageBox.Show("Succeed!"); }
            else { MessageBox.Show("error404!"); }
            sqlConnection.Close();

        }
    }
}
