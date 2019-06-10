using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 上机实习二
{
    public partial class MainSys : Form
    {
        public MainSys()
        {
            InitializeComponent();
        }

        private void 交会计算ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            交会计算 child = new 交会计算();
            child.MdiParent = this;
            child.Show();
        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否要退出系统", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();

        }

        private void 距离和方位角计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            距离与坐标方位角 child = new 距离与坐标方位角();
            child.MdiParent = this;
            child.Show();
        }

        private void 矩阵计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           矩阵计算  child = new 矩阵计算 ();
            child.MdiParent = this;
            child.Show();
        }

        private void 角度转化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            角度转换 child = new 角度转换 ();
            child.MdiParent = this;
            child.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("曾建顺", "作者", MessageBoxButtons.OK);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 打开结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            计算结果 child = new 计算结果();
            child.MdiParent = this;
            child.Show();
            
        }

        

       
        private void 数据库操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            数据库 child = new 数据库();
            child.MdiParent = this;
            child.Show();
        }
    }
}
