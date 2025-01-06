namespace 保存数据到本地
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.get2 = new System.Windows.Forms.Button();
            this.get3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save4 = new System.Windows.Forms.Button();
            this.get4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 24);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 23);
            this.save.TabIndex = 0;
            this.save.Text = "method1";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(173, 8);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(126, 29);
            this.get.TabIndex = 1;
            this.get.Text = "文件系统获取";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 4;
            // 
            // get2
            // 
            this.get2.Location = new System.Drawing.Point(173, 43);
            this.get2.Name = "get2";
            this.get2.Size = new System.Drawing.Size(126, 29);
            this.get2.TabIndex = 5;
            this.get2.Text = "注册表获取";
            this.get2.UseVisualStyleBackColor = true;
            this.get2.Click += new System.EventHandler(this.get2_Click);
            // 
            // get3
            // 
            this.get3.Location = new System.Drawing.Point(173, 78);
            this.get3.Name = "get3";
            this.get3.Size = new System.Drawing.Size(126, 29);
            this.get3.TabIndex = 6;
            this.get3.Text = "缓存获取";
            this.get3.UseVisualStyleBackColor = true;
            this.get3.Click += new System.EventHandler(this.get3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "method2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "method3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "save";
            // 
            // save4
            // 
            this.save4.Location = new System.Drawing.Point(16, 111);
            this.save4.Name = "save4";
            this.save4.Size = new System.Drawing.Size(122, 23);
            this.save4.TabIndex = 10;
            this.save4.Text = "method4";
            this.save4.UseVisualStyleBackColor = true;
            this.save4.Click += new System.EventHandler(this.save4_Click);
            // 
            // get4
            // 
            this.get4.Location = new System.Drawing.Point(173, 113);
            this.get4.Name = "get4";
            this.get4.Size = new System.Drawing.Size(126, 29);
            this.get4.TabIndex = 10;
            this.get4.Text = "多文件系统获取";
            this.get4.UseVisualStyleBackColor = true;
            this.get4.Click += new System.EventHandler(this.get4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.get4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.get3);
            this.Controls.Add(this.get2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button get2;
        private System.Windows.Forms.Button get3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save4;
        private System.Windows.Forms.Button get4;
    }
}

