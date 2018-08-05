namespace CPSTest
{
    partial class Chart
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
			this.drawPanel = new System.Windows.Forms.Panel();
			this.peakCPSLbl = new System.Windows.Forms.Label();
			this.valleyCPSLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// drawPanel
			// 
			this.drawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.drawPanel.Location = new System.Drawing.Point(90, 10);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(500, 180);
			this.drawPanel.TabIndex = 0;
			this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Repaint);
			// 
			// peakCPSLbl
			// 
			this.peakCPSLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.peakCPSLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			this.peakCPSLbl.Location = new System.Drawing.Point(0, 2);
			this.peakCPSLbl.Name = "peakCPSLbl";
			this.peakCPSLbl.Size = new System.Drawing.Size(84, 17);
			this.peakCPSLbl.TabIndex = 1;
			this.peakCPSLbl.Text = "Peak:";
			this.peakCPSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// valleyCPSLbl
			// 
			this.valleyCPSLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.valleyCPSLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.valleyCPSLbl.Location = new System.Drawing.Point(0, 19);
			this.valleyCPSLbl.Name = "valleyCPSLbl";
			this.valleyCPSLbl.Size = new System.Drawing.Size(84, 17);
			this.valleyCPSLbl.TabIndex = 2;
			this.valleyCPSLbl.Text = "Valley:";
			this.valleyCPSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.ClientSize = new System.Drawing.Size(600, 196);
			this.Controls.Add(this.valleyCPSLbl);
			this.Controls.Add(this.peakCPSLbl);
			this.Controls.Add(this.drawPanel);
			this.MaximumSize = new System.Drawing.Size(616, 235);
			this.MinimumSize = new System.Drawing.Size(616, 235);
			this.Name = "Chart";
			this.Text = "Chart";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
			this.Load += new System.EventHandler(this.Chart_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Label peakCPSLbl;
        private System.Windows.Forms.Label valleyCPSLbl;
    }
}