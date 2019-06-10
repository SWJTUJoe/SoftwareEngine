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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text) == true)
                button1.Enabled = false;
            if (string .IsNullOrEmpty(textBox2.Text)==true)            
                MessageBox.Show("请输入密码","信息提示",MessageBoxButtons.OK);
            //连接数据库
            //Data Source = JEOS - DESKTOP; Initial Catalog = 2017114312; Integrated Security = True

            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            String myconn = @"Data Source = (local); Initial Catalog = 2017114312; Integrated Security = True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            String sql = "select Client_ID,Client_Key from PEOPLE where Client_ID='" + username + "'and Client_key='" + password + "'";//SQL语句实现表数据的读取
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)//满足用户名与密码一致，进入下一个界面
            {
                MainSys frm = new MainSys();
                
                this.Close();
               new System.Threading.Thread(() =>
               {
                   Application.Run(new MainSys());
                   }).Start(); 
             
               
            }
            else//如果登录失败，询问是否注册新用户
            {
                DialogResult dr = MessageBox.Show("账号不存在，是否注册新用户？", "登录失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)//打开注册界面
                {
                    注册 form2 = new 注册();
                   
                    this.Close();
                    new System.Threading.Thread(() =>
                    {
                        Application.Run(new 注册());
                    }).Start();
                }
                else
                {
                    this.Show();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://xiaoyouxi.2345.com/");
        }
    }
}
