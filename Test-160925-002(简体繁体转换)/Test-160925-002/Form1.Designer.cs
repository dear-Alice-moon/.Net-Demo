namespace Test_160925_002
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
            this.txtJianTi = new System.Windows.Forms.TextBox();
            this.txtFanTi = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJianTi
            // 
            this.txtJianTi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJianTi.Location = new System.Drawing.Point(31, 22);
            this.txtJianTi.Multiline = true;
            this.txtJianTi.Name = "txtJianTi";
            this.txtJianTi.Size = new System.Drawing.Size(474, 172);
            this.txtJianTi.TabIndex = 0;
            // 
            // txtFanTi
            // 
            this.txtFanTi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFanTi.Location = new System.Drawing.Point(31, 265);
            this.txtFanTi.Multiline = true;
            this.txtFanTi.Name = "txtFanTi";
            this.txtFanTi.Size = new System.Drawing.Size(474, 172);
            this.txtFanTi.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(31, 213);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(81, 30);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "简体转繁体";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 469);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtFanTi);
            this.Controls.Add(this.txtJianTi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJianTi;
        private System.Windows.Forms.TextBox txtFanTi;
        private System.Windows.Forms.Button btnConvert;
    }
}

