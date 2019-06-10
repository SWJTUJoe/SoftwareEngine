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
using System.Threading;

namespace 上机实习二
{
    public partial class 计算结果 : Form
    {
        public 计算结果()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            
                StreamReader sr = new StreamReader(@"C:\Users\ll\Desktop\作业\C#\上机实习二\上机实习二\result.txt");
                this.richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
        }    
    }
    
}
