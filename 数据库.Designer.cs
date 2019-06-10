namespace 上机实习二
{
    partial class 数据库
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cal_ResultDataSet = new 上机实习二.Cal_ResultDataSet();
            this.calResultDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cal_ResultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calResultDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // cal_ResultDataSet
            // 
            this.cal_ResultDataSet.DataSetName = "Cal_ResultDataSet";
            this.cal_ResultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calResultDataSetBindingSource
            // 
            this.calResultDataSetBindingSource.DataSource = this.cal_ResultDataSet;
            this.calResultDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "距离结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(735, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "显示数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(941, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "方位角结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(771, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "删除数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 41);
            this.button5.TabIndex = 6;
            this.button5.Text = "修改数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 412);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "显示数据";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(941, 352);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1012, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "前方交会";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(771, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "删除数据";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(448, 412);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 41);
            this.button8.TabIndex = 6;
            this.button8.Text = "修改数据";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(98, 412);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 41);
            this.button9.TabIndex = 5;
            this.button9.Text = "显示数据";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(36, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(941, 352);
            this.dataGridView3.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1012, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "后方交会";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(771, 412);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 41);
            this.button10.TabIndex = 7;
            this.button10.Text = "删除数据";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(448, 412);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(147, 41);
            this.button11.TabIndex = 6;
            this.button11.Text = "修改数据";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(98, 412);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(147, 41);
            this.button12.TabIndex = 5;
            this.button12.Text = "显示数据";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(36, 33);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.Size = new System.Drawing.Size(941, 352);
            this.dataGridView4.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button13);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.button15);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1012, 486);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "距离交会";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(774, 404);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 41);
            this.button13.TabIndex = 7;
            this.button13.Text = "删除数据";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(451, 404);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(147, 41);
            this.button14.TabIndex = 6;
            this.button14.Text = "修改数据";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(101, 404);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(147, 41);
            this.button15.TabIndex = 5;
            this.button15.Text = "显示数据";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(39, 25);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 30;
            this.dataGridView5.Size = new System.Drawing.Size(941, 352);
            this.dataGridView5.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button16);
            this.tabPage6.Controls.Add(this.button17);
            this.tabPage6.Controls.Add(this.button18);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1012, 486);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "侧方交会";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(764, 407);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(147, 41);
            this.button16.TabIndex = 7;
            this.button16.Text = "删除数据";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(441, 407);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(147, 41);
            this.button17.TabIndex = 6;
            this.button17.Text = "修改数据";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(91, 407);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(147, 41);
            this.button18.TabIndex = 5;
            this.button18.Text = "显示数据";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(29, 28);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 30;
            this.dataGridView6.Size = new System.Drawing.Size(941, 352);
            this.dataGridView6.TabIndex = 4;
            // 
            // 数据库
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "数据库";
            this.Text = "数据库";
            this.Load += new System.EventHandler(this.数据库_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cal_ResultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calResultDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource calResultDataSetBindingSource;
        private Cal_ResultDataSet cal_ResultDataSet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridView dataGridView6;
    }
}