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
			this.Time = new System.Windows.Forms.Label();
			this.TestTimeBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.TestTimeBox)).BeginInit();
			this.SuspendLayout();
			// 
			// sign
			// 
			this.sign.AutoSize = true;
			this.sign.Location = new System.Drawing.Point(0, 0);
			this.sign.Margin = new System.Windows.Forms.Padding(0);
			this.sign.Name = "sign";
			this.sign.Size = new System.Drawing.Size(241, 15);
			this.sign.TabIndex = 0;
			this.sign.Text = "Click Per Second Test Program  ver 0.3 by C7";
			// 
			// cpsDisplay
			// 
			this.cpsDisplay.AutoSize = true;
			this.cpsDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.cpsDisplay.Location = new System.Drawing.Point(0, 17);
			this.cpsDisplay.Margin = new System.Windows.Forms.Padding(0);
			this.cpsDisplay.Name = "cpsDisplay";
			this.cpsDisplay.Size = new System.Drawing.Size(94, 15);
			this.cpsDisplay.TabIndex = 1;
			this.cpsDisplay.Text = "CPS Information";
			// 
			// beginButton
			// 
			this.beginButton.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.beginButton.ForeColor = System.Drawing.Color.Black;
			this.beginButton.Location = new System.Drawing.Point(162, 78);
			this.beginButton.Name = "beginButton";
			this.beginButton.Size = new System.Drawing.Size(60, 36);
			this.beginButton.TabIndex = 2;
			this.beginButton.Text = "Start";
			this.beginButton.UseVisualStyleBackColor = true;
			this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
			// 
			// clickButton
			// 
			this.clickButton.Font = new System.Drawing.Font("Segoe UI", 32F);
			this.clickButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.clickButton.Location = new System.Drawing.Point(12, 43);
			this.clickButton.Name = "clickButton";
			this.clickButton.Size = new System.Drawing.Size(360, 106);
			this.clickButton.TabIndex = 3;
			this.clickButton.Text = "Click Me !!!";
			this.clickButton.UseVisualStyleBackColor = true;
			this.clickButton.Visible = false;
			this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
			// 
			// ProgressBar
			// 
			this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.ProgressBar.Location = new System.Drawing.Point(0, 155);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(384, 10);
			this.ProgressBar.TabIndex = 4;
			// 
			// Time
			// 
			this.Time.AutoSize = true;
			this.Time.Location = new System.Drawing.Point(273, 0);
			this.Time.Name = "Time";
			this.Time.Size = new System.Drawing.Size(113, 15);
			this.Time.TabIndex = 5;
			this.Time.Text = "Test Time (second) :";
			// 
			// TestTimeBox
			// 
			this.TestTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.TestTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TestTimeBox.ForeColor = System.Drawing.Color.White;
			this.TestTimeBox.Location = new System.Drawing.Point(276, 17);
			this.TestTimeBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.TestTimeBox.Name = "TestTimeBox";
			this.TestTimeBox.Size = new System.Drawing.Size(96, 19);
			this.TestTimeBox.TabIndex = 6;
			this.TestTimeBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.TestTimeBox);
			this.Controls.Add(this.Time);
			this.Controls.Add(this.beginButton);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.clickButton);
			this.Controls.Add(this.cpsDisplay);
			this.Controls.Add(this.sign);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.White;
			this.MaximumSize = new System.Drawing.Size(400, 200);
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "main";
			this.Text = "CPSTest";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
			this.Load += new System.EventHandler(this.main_Load);
			((System.ComponentModel.ISupportInitialize)(this.TestTimeBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label cpsDisplay;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Panel ProgressBar;
		private System.Windows.Forms.Label Time;
		private System.Windows.Forms.NumericUpDown TestTimeBox;
	}
}

