namespace CPSTest
{
    partial class main
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
            this.sign = new System.Windows.Forms.Label();
            this.cpsDisplay = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.clickButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign.ForeColor = System.Drawing.Color.White;
            this.sign.Location = new System.Drawing.Point(0, 0);
            this.sign.Margin = new System.Windows.Forms.Padding(0);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(272, 17);
            this.sign.TabIndex = 0;
            this.sign.Text = "Click Per Second Test Program  ver 0.1 by C7";
            // 
            // cpsDisplay
            // 
            this.cpsDisplay.AutoSize = true;
            this.cpsDisplay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpsDisplay.ForeColor = System.Drawing.Color.Red;
            this.cpsDisplay.Location = new System.Drawing.Point(0, 17);
            this.cpsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.cpsDisplay.Name = "cpsDisplay";
            this.cpsDisplay.Size = new System.Drawing.Size(102, 17);
            this.cpsDisplay.TabIndex = 1;
            this.cpsDisplay.Text = "CPS Information";
            // 
            // beginButton
            // 
            this.beginButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beginButton.ForeColor = System.Drawing.Color.Black;
            this.beginButton.Location = new System.Drawing.Point(112, 78);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(60, 36);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Start";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // clickButton
            // 
            this.clickButton.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clickButton.ForeColor = System.Drawing.Color.Red;
            this.clickButton.Location = new System.Drawing.Point(12, 38);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(260, 116);
            this.clickButton.TabIndex = 3;
            this.clickButton.Text = "Click Me !!!";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Visible = false;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ProgressBar.Location = new System.Drawing.Point(0, 160);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(284, 5);
            this.ProgressBar.TabIndex = 4;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.cpsDisplay);
            this.Controls.Add(this.sign);
            this.Name = "main";
            this.Text = "CPSTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label cpsDisplay;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Panel ProgressBar;
    }
}

