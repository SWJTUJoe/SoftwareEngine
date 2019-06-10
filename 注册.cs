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
    public partial class 注册 : Form
    {
        public 注册()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password, repassword;
            username = textBox1.Text;
            password = textBox2.Text;
            repassword = textBox3.Text;
            if (password == repassword)//两次输入的密码一致
            {
                string myConn = @"Data Source = (local); Initial Catalog = 2017114312; Integrated Security = True
";
                SqlConnection sqlConnection = new SqlConnection(myConn);  //实例化连接对象
                sqlConnection.Open();//打开数据库
                String sql = "INSERT INTO PEOPLE(Client_ID,Client_key) VALUES('" + username + "','" + password + "')";//SQL语句向表中写入数据
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("注册成功");
                this.Close();
                Login frm = new Login();
                frm.ShowDialog();
                //数据库访问流程：
                //1.建立Connection对象，创建一个数据库连接
                //2.在建立连接的基础上可以使用Command对象对数据库发送查询、新增、修改和删除等命令
                //3.创建DataAdapter对象，从数据库中获取数据
                //4.创建DataSet对象，将DataAdapter对象填充到DataSet对象中（数据集）
                //5.如果需要，可以重复操作，在一个DataSet对象中可以容纳多个数据集合
                //6.关闭数据连接
                //7.在DataSet上进行数据操作
            }
            else
            {
                MessageBox.Show("密码不一致");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
