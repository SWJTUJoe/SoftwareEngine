using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 上机实习二
{
    public partial class 数据库 : Form
    {
        public 数据库()
        {
            InitializeComponent();
        }
        

        //距离计算
        private void button1_Click(object sender, EventArgs e)//显示数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            string selectSql = "select * from Dis_Result";

            SqlCommand sqlselect = new SqlCommand(selectSql, sqlConnection);
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlselect);
            adapter.Fill(dt);

            this.dataGridView1.DataSource = dt;
            sqlConnection.Close();

        }
       
            private void button2_Click(object sender, EventArgs e)//修改数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Result = new Data();
                //string id = dataGridView1.Rows[i].Cells["id"].EditedFormattedValue.ToString();
                Point1.P_x =Convert.ToDecimal( dataGridView1.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Result.Result = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Distance"].EditedFormattedValue.ToString());
                string scmdStr = "update Dis_Result set  Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y+ ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ",Distance=" + Result.Result + " where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");



        }

    private void button3_Click(object sender, EventArgs e)//删除数据
        {
             
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = this.dataGridView1.CurrentRow.Index;//得到行号
                string Distance = this.dataGridView1.Rows[id].Cells["Distance"].Value.ToString();//得到该行数据
                decimal D = decimal.Round(decimal.Parse(Distance),4);
                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[id]);//删除dataGridView的选定行的数据
                string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();//打开数据库
                string Delete_cmd = "delete from Dis_Result where Distance=" + Distance + "";
                SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

                int n = sqlCommand.ExecuteNonQuery();
                if (n != 1)
                {
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    MessageBox.Show("删除成功！");
                }
            }


        }
        //方位角计算
        private void button6_Click(object sender, EventArgs e)//显示数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            string selectSql = "select * from Angle_Result";

            SqlCommand sqlselect = new SqlCommand(selectSql, sqlConnection);
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlselect);
            adapter.Fill(dt);

            this.dataGridView2.DataSource = dt;
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)//删除数据
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = this.dataGridView2.CurrentRow.Index;//得到行号
                string Angle = this.dataGridView2.Rows[id].Cells["Angle"].Value.ToString();//得到该行数据
               
                this.dataGridView2.Rows.Remove(this.dataGridView2.Rows[id]);//删除dataGridView的选定行的数据
                string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();//打开数据库
                string Delete_cmd = "delete from Angle_Result where Angle='" + Angle + "'";
                SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

                int n = sqlCommand.ExecuteNonQuery();
                if (n != 1)
                {
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    MessageBox.Show("删除成功！");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)//更新数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Result = new Data();
                //string id = dataGridView1.Rows[i].Cells["id"].EditedFormattedValue.ToString();
                Point1.P_x = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Result.A_Result = dataGridView2.Rows[i].Cells["Angle"].EditedFormattedValue.ToString();
                string scmdStr = "update Angle_Result set  Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y + ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ",Angle='" + Result.A_Result + "' where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //前方交会
        private void button9_Click(object sender, EventArgs e)//显示数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            string selectSql = "select * from Forward_Inter";

            SqlCommand sqlselect = new SqlCommand(selectSql, sqlConnection);
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlselect);
            adapter.Fill(dt);

            this.dataGridView3.DataSource = dt;
            sqlConnection.Close();

        }

        private void button8_Click(object sender, EventArgs e)//更新数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView3.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Result = new Data();
                //string id = dataGridView3.Rows[i].Cells["id"].EditedFormattedValue.ToString();
                Point1.P_x = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Result.A_Result = dataGridView3.Rows[i].Cells["Angle_A"].EditedFormattedValue.ToString();
                Result.B_Result = dataGridView3.Rows[i].Cells["Angle_B"].EditedFormattedValue.ToString();
                Result.P_x = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Result_x"].EditedFormattedValue.ToString());
                Result.P_y = Convert.ToDecimal(dataGridView3.Rows[i].Cells["Result_y"].EditedFormattedValue.ToString());
                string scmdStr = "update set  Forward_Inter  Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y + ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ",Angle_A='" + Result.A_Result + "',Angle_B='" + Result.B_Result + "',Result_x=" + Result.P_x + "," +
                    "  Result_y=" + Point1.P_y + "" +" where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");
        }

        private void button7_Click(object sender, EventArgs e)//删除数据
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = this.dataGridView3.CurrentRow.Index;//得到行号
                string Result_y = this.dataGridView3.Rows[id].Cells["Result_y"].Value.ToString();//得到该行数据
                decimal Y= decimal.Round(decimal.Parse(Result_y), 4);
                this.dataGridView3.Rows.Remove(this.dataGridView3.Rows[id]);//删除dataGridView的选定行的数据
                string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();//打开数据库
                string Delete_cmd = "delete from Forward_Inter  where Result_y=" + Y + "";
                SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

                int n = sqlCommand.ExecuteNonQuery();
                if (n != 1)
                {
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    MessageBox.Show("删除成功！");
                }
            }
        }
        //后方交会

        private void button12_Click(object sender, EventArgs e)//显示数据
        {
            string Mystr =@"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(Mystr);
            sqlConnection.Open();
            string cnn = "select * from Resection";
            SqlCommand command = new SqlCommand(cnn,sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.SelectCommand = command;

            DataSet d = new DataSet();
            dataAdapter.Fill(d, "Resection");
      
            this.dataGridView4.DataSource = d.Tables["Resection"];
           
            sqlConnection.Close();
        }

        private void button10_Click(object sender, EventArgs e)//删除数据
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = this.dataGridView4.CurrentRow.Index;//得到行号
                string Result_y = this.dataGridView4.Rows[id].Cells["Result_y"].Value.ToString();//得到该行数据
                decimal Y = decimal.Round(decimal.Parse(Result_y), 4);
                this.dataGridView4.Rows.Remove(this.dataGridView4.Rows[id]);//删除dataGridView的选定行的数据
                string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();//打开数据库
                string Delete_cmd = "delete from Resection where Result_y=" + Y + "";
                SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

                int n = sqlCommand.ExecuteNonQuery();
                if (n != 1)
                {
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    MessageBox.Show("删除成功！");
                }
            }



        }
        private void 数据库_Load(object sender, EventArgs e)
        {
            
        }
        private void button11_Click(object sender, EventArgs e)//更新数据
        {

            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView4.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Point3 = new Data();
                Data Result = new Data();
               
                Point1.P_x = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Point3.P_x = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point3_x"].EditedFormattedValue.ToString());
                Point3.P_y = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Point3_y"].EditedFormattedValue.ToString());
                Result.A_Result = dataGridView4.Rows[i].Cells["Angle_A"].EditedFormattedValue.ToString();
                Result.B_Result = dataGridView4.Rows[i].Cells["Angle_B"].EditedFormattedValue.ToString();
                Result.C_Result = dataGridView4.Rows[i].Cells["Angle_C"].EditedFormattedValue.ToString();
                Result.P_x = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Result_x"].EditedFormattedValue.ToString());
                Result.P_y = Convert.ToDecimal(dataGridView4.Rows[i].Cells["Result_y"].EditedFormattedValue.ToString());
                string scmdStr = "update Resection set  Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y + ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ", Point3_x=" + Point3.P_x + ", Point3_y=" + Point3.P_y + ",  Angle_A='" + Result.A_Result + "',Angle_B='" 
                    + Result.B_Result + "', Angle_C='" + Result.C_Result + "',Result_x=" + Result.P_x + "," +
                    "  Result_y=" + Point1.P_y + "" + " where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                int n=sqlcmd.ExecuteNonQuery();
               

            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");
        }
        //距离交会
        private void button15_Click(object sender, EventArgs e)//显示数据
        {
            string Mystr = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(Mystr);
            sqlConnection.Open();
            string cnn = "select * from Dis_Rendezvous";
            SqlCommand command = new SqlCommand(cnn, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.SelectCommand = command;

            DataSet d = new DataSet();
            dataAdapter.Fill(d, "Dis_Rendezvous");

            this.dataGridView5.DataSource = d.Tables["Dis_Rendezvous"];
            sqlConnection.Close();
        }

        private void button13_Click(object sender, EventArgs e)//删除数据
        {
            int id = this.dataGridView5.CurrentRow.Index;//得到行号
            string Result_y = this.dataGridView5.Rows[id].Cells["Result_y"].Value.ToString();//得到该行数据
            decimal Y = decimal.Round(decimal.Parse(Result_y), 4);
            this.dataGridView5.Rows.Remove(this.dataGridView5.Rows[id]);//删除dataGridView的选定行的数据
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            string Delete_cmd = "delete from Dis_Rendezvous where Result_y=" + Y + "";
            SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

            int n = sqlCommand.ExecuteNonQuery();
            if (n != 1)
            {
                MessageBox.Show("删除失败！");
            }
            else
            {
                MessageBox.Show("删除成功！");
            }
        }

        private void button14_Click(object sender, EventArgs e)//更新数据
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView5.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Result = new Data();
               
                Point1.P_x = Convert.ToDecimal(dataGridView5.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView5.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView5.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView5.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Result.Result = Convert.ToDecimal(dataGridView5.Rows[i].Cells["Distance_A"].EditedFormattedValue.ToString());
                Result.Distance = Convert.ToDouble(dataGridView5.Rows[i].Cells["Distance_B"].EditedFormattedValue.ToString());
                string scmdStr = "update  Dis_Rendezvous set  Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y + ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ",Distance_A=" + Result.Result + ",Distance_B=" + Result.Distance + "  where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");
        }
        //侧方交会
        private void button18_Click(object sender, EventArgs e)//显示数据
        {
            string Mystr = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(Mystr);
            sqlConnection.Open();
            string cnn = "select * from Side_intersection";
            SqlCommand command = new SqlCommand(cnn, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.SelectCommand = command;

            DataSet d = new DataSet();
            dataAdapter.Fill(d, "Side_intersection");

            this.dataGridView6.DataSource = d.Tables["Side_intersection"];
            sqlConnection.Close();
        }

        private void button16_Click(object sender, EventArgs e)//删除数据
        {
            int id = this.dataGridView6.CurrentRow.Index;//得到行号
            string Result_y = this.dataGridView6.Rows[id].Cells["Result_y"].Value.ToString();//得到该行数据
            decimal Y = decimal.Round(decimal.Parse(Result_y), 4);
            this.dataGridView6.Rows.Remove(this.dataGridView6.Rows[id]);//删除dataGridView的选定行的数据
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            string Delete_cmd = "delete from Side_intersection where Result_y=" + Y + "";
            SqlCommand sqlCommand = new SqlCommand(Delete_cmd, sqlConnection);//创建命令对象

            int n = sqlCommand.ExecuteNonQuery();
            if (n != 1)
            {
                MessageBox.Show("删除失败！");
            }
            else
            {
                MessageBox.Show("删除成功！");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string myConn = @"Data Source = (local); Initial Catalog = Cal_Result; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
            sqlConnection.Open();//打开数据库
            for (int i = 0; i < dataGridView6.Rows.Count-1; i++)//逐行将dataGridView中的数据写入数据库
            {
                Data Point1 = new Data();
                Data Point2 = new Data();
                Data Result = new Data();
               
                Point1.P_x = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Point1_x"].EditedFormattedValue.ToString());
                Point1.P_y = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Point1_y"].EditedFormattedValue.ToString());
                Point2.P_x = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Point2_x"].EditedFormattedValue.ToString());
                Point2.P_y = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Point2_y"].EditedFormattedValue.ToString());
                Result.A_Result = dataGridView6.Rows[i].Cells["Angle_A"].EditedFormattedValue.ToString();
                Result.B_Result = dataGridView6.Rows[i].Cells["Angle_B"].EditedFormattedValue.ToString();
                Result.P_x = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Result_x"].EditedFormattedValue.ToString());
                Result.P_y = Convert.ToDecimal(dataGridView6.Rows[i].Cells["Result_y"].EditedFormattedValue.ToString());
                string scmdStr = "update  Side_intersection set Point1_x=" + Point1.P_x + ", Point1_y=" + Point1.P_y + ", Point2_x=" + Point2.P_x + " ," +
                    "Point2_y=" + Point2.P_y + ",Angle_A='" + Result.A_Result + "',Angle_B='" + Result.B_Result + "',Result_x=" + Result.P_x + "," +
                    "  Result_y=" + Point1.P_y + "" + " where Point1_x=" + Point1.P_x + "";
                SqlCommand sqlcmd = new SqlCommand(scmdStr, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            MessageBox.Show("更新成功！");
        }
    }

       
 }

