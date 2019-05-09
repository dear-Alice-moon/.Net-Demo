namespace Test_161101_004
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.uControlButtonExt21 = new Test_161101_004.UControlButtonExt2();
            this.uControlButtonExt1 = new Test_161101_004.UControlButtonExt();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uControlButtonExt21
            // 
            this.uControlButtonExt21.Location = new System.Drawing.Point(31, 126);
            this.uControlButtonExt21.Name = "uControlButtonExt21";
            this.uControlButtonExt21.Size = new System.Drawing.Size(224, 63);
            this.uControlButtonExt21.TabIndex = 2;
            // 
            // uControlButtonExt1
            // 
            this.uControlButtonExt1.Location = new System.Drawing.Point(136, 12);
            this.uControlButtonExt1.Name = "uControlButtonExt1";
            this.uControlButtonExt1.Size = new System.Drawing.Size(213, 72);
            this.uControlButtonExt1.TabIndex = 1;
            this.uControlButtonExt1.Load += new System.EventHandler(this.uControlButtonExt1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 477);
            this.Controls.Add(this.uControlButtonExt21);
            this.Controls.Add(this.uControlButtonExt1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UControlButtonExt uControlButtonExt1;
        private UControlButtonExt2 uControlButtonExt21;
    }
}

