namespace imgFormat
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
            this.components = new System.ComponentModel.Container();
            this.btnMd = new System.Windows.Forms.Button();
            this.btnFd = new System.Windows.Forms.Button();
            this.prefix_box = new System.Windows.Forms.TextBox();
            this.log_box = new System.Windows.Forms.TextBox();
            this.usage_box = new System.Windows.Forms.TextBox();
            this.num_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.length_box = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMd
            // 
            this.btnMd.BackColor = System.Drawing.SystemColors.Control;
            this.btnMd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMd.Location = new System.Drawing.Point(12, 93);
            this.btnMd.Name = "btnMd";
            this.btnMd.Size = new System.Drawing.Size(167, 51);
            this.btnMd.TabIndex = 0;
            this.btnMd.Text = "Markdown ";
            this.btnMd.UseVisualStyleBackColor = false;
            this.btnMd.Click += new System.EventHandler(this.btnProcessMarkdown_Click);
            // 
            // btnFd
            // 
            this.btnFd.BackColor = System.Drawing.SystemColors.Control;
            this.btnFd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFd.Location = new System.Drawing.Point(12, 150);
            this.btnFd.Name = "btnFd";
            this.btnFd.Size = new System.Drawing.Size(167, 53);
            this.btnFd.TabIndex = 1;
            this.btnFd.Text = "Folder";
            this.btnFd.UseVisualStyleBackColor = false;
            this.btnFd.Click += new System.EventHandler(this.btnProcessFolder_Click);
            // 
            // prefix_box
            // 
            this.prefix_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prefix_box.Location = new System.Drawing.Point(12, 39);
            this.prefix_box.Name = "prefix_box";
            this.prefix_box.Size = new System.Drawing.Size(74, 21);
            this.prefix_box.TabIndex = 2;
            this.prefix_box.Text = "42";
            this.prefix_box.TextChanged += new System.EventHandler(this.prefix_box_TextChanged);
            // 
            // log_box
            // 
            this.log_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_box.Location = new System.Drawing.Point(193, 0);
            this.log_box.Multiline = true;
            this.log_box.Name = "log_box";
            this.log_box.ReadOnly = true;
            this.log_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_box.Size = new System.Drawing.Size(357, 459);
            this.log_box.TabIndex = 3;
            this.log_box.Text = "日志输出：";
            // 
            // usage_box
            // 
            this.usage_box.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usage_box.Location = new System.Drawing.Point(12, 209);
            this.usage_box.Multiline = true;
            this.usage_box.Name = "usage_box";
            this.usage_box.ReadOnly = true;
            this.usage_box.Size = new System.Drawing.Size(167, 238);
            this.usage_box.TabIndex = 4;
            this.usage_box.Text = "MarkDown图片名称处理工具，也可以对某一文件夹内图片进行处理。\r\n\r\nMarkDown 按钮：对.md文件内引用的图片进行重命名并转换为jpg格式。\r\nFo" +
    "lder按钮：对某一文件夹内所有图片重命名并转换为jpg格式。\r\n\r\n命名规则：图片前缀+编号(数字）,中间补0使所有图片名称长度统一。";
            // 
            // num_box
            // 
            this.num_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_box.Location = new System.Drawing.Point(105, 39);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(74, 21);
            this.num_box.TabIndex = 2;
            this.num_box.Text = "1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 14);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "图片前缀：";
            this.textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox2.Location = new System.Drawing.Point(105, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(74, 14);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "起始图片编号:";
            this.textBox2.UseWaitCursor = true;
            // 
            // length_box
            // 
            this.length_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.length_box.Location = new System.Drawing.Point(105, 66);
            this.length_box.Name = "length_box";
            this.length_box.Size = new System.Drawing.Size(74, 21);
            this.length_box.TabIndex = 2;
            this.length_box.Text = "7";
            this.length_box.TextChanged += new System.EventHandler(this.prefix_box_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox3.Location = new System.Drawing.Point(12, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(74, 14);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "图片名长度：";
            this.textBox3.UseWaitCursor = true;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 459);
            this.Controls.Add(this.usage_box);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.num_box);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.length_box);
            this.Controls.Add(this.prefix_box);
            this.Controls.Add(this.btnFd);
            this.Controls.Add(this.btnMd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMd;
        private System.Windows.Forms.Button btnFd;
        private System.Windows.Forms.TextBox prefix_box;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.TextBox usage_box;
        private System.Windows.Forms.TextBox num_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox length_box;
        private System.Windows.Forms.TextBox textBox3;
    }
}

