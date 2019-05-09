namespace Test_160904_002
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
            this.userPlayer = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.Label();
            this.computerPlayer = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userPlayer
            // 
            this.userPlayer.AutoSize = true;
            this.userPlayer.Location = new System.Drawing.Point(47, 46);
            this.userPlayer.Name = "userPlayer";
            this.userPlayer.Size = new System.Drawing.Size(52, 15);
            this.userPlayer.TabIndex = 0;
            this.userPlayer.Text = "玩家：";
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Location = new System.Drawing.Point(136, 46);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(55, 15);
            this.users.TabIndex = 1;
            this.users.Text = "label2";
            // 
            // computerPlayer
            // 
            this.computerPlayer.AutoSize = true;
            this.computerPlayer.Location = new System.Drawing.Point(309, 46);
            this.computerPlayer.Name = "computerPlayer";
            this.computerPlayer.Size = new System.Drawing.Size(45, 15);
            this.computerPlayer.TabIndex = 2;
            this.computerPlayer.Text = "电脑:";
            // 
            // computer
            // 
            this.computer.AutoSize = true;
            this.computer.Location = new System.Drawing.Point(409, 46);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(55, 15);
            this.computer.TabIndex = 3;
            this.computer.Text = "label4";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(85, 107);
            this.lblResult.MaximumSize = new System.Drawing.Size(400, 90);
            this.lblResult.MinimumSize = new System.Drawing.Size(400, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(400, 90);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label5";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(50, 248);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "石头";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(228, 247);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "剪刀";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(412, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "布";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 361);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.computerPlayer);
            this.Controls.Add(this.users);
            this.Controls.Add(this.userPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userPlayer;
        private System.Windows.Forms.Label users;
        private System.Windows.Forms.Label computerPlayer;
        private System.Windows.Forms.Label computer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

