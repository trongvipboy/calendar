namespace LapLichCongViec
{
    partial class CongViecTrongNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongViecTrongNgay));
            this.plListJob = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JobTomorrow = new System.Windows.Forms.Button();
            this.JobYesterday = new System.Windows.Forms.Button();
            this.dtpDateOfJob = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plListJob
            // 
            this.plListJob.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.plListJob.Location = new System.Drawing.Point(0, 59);
            this.plListJob.Name = "plListJob";
            this.plListJob.Size = new System.Drawing.Size(587, 301);
            this.plListJob.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmViệcToolStripMenuItem,
            this.hômNayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmViệcToolStripMenuItem
            // 
            this.thêmViệcToolStripMenuItem.Name = "thêmViệcToolStripMenuItem";
            this.thêmViệcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thêmViệcToolStripMenuItem.Text = "Thêm việc";
            this.thêmViệcToolStripMenuItem.Click += new System.EventHandler(this.thêmViệcToolStripMenuItem_Click);
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hômNayToolStripMenuItem.Text = "Hôm nay";
            this.hômNayToolStripMenuItem.Click += new System.EventHandler(this.hômNayToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.JobTomorrow);
            this.panel1.Controls.Add(this.JobYesterday);
            this.panel1.Controls.Add(this.dtpDateOfJob);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 26);
            this.panel1.TabIndex = 4;
            // 
            // JobTomorrow
            // 
            this.JobTomorrow.Location = new System.Drawing.Point(514, 0);
            this.JobTomorrow.Name = "JobTomorrow";
            this.JobTomorrow.Size = new System.Drawing.Size(75, 26);
            this.JobTomorrow.TabIndex = 2;
            this.JobTomorrow.Text = "Ngày sau";
            this.JobTomorrow.UseVisualStyleBackColor = true;
            this.JobTomorrow.Click += new System.EventHandler(this.JobTomorrow_Click);
            // 
            // JobYesterday
            // 
            this.JobYesterday.Location = new System.Drawing.Point(0, 0);
            this.JobYesterday.Name = "JobYesterday";
            this.JobYesterday.Size = new System.Drawing.Size(75, 26);
            this.JobYesterday.TabIndex = 1;
            this.JobYesterday.Text = "Hôm trước";
            this.JobYesterday.UseVisualStyleBackColor = true;
            this.JobYesterday.Click += new System.EventHandler(this.JobYesterday_Click);
            // 
            // dtpDateOfJob
            // 
            this.dtpDateOfJob.Location = new System.Drawing.Point(192, 3);
            this.dtpDateOfJob.Name = "dtpDateOfJob";
            this.dtpDateOfJob.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfJob.TabIndex = 0;
            this.dtpDateOfJob.ValueChanged += new System.EventHandler(this.dtpDateOfJob_ValueChanged);
            // 
            // CongViecTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 360);
            this.Controls.Add(this.plListJob);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CongViecTrongNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công việc trong ngày";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CongViecTrongNgay_FormClosed);
            this.Load += new System.EventHandler(this.CongViecTrongNgay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel plListJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hômNayToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button JobTomorrow;
        private System.Windows.Forms.Button JobYesterday;
        private System.Windows.Forms.DateTimePicker dtpDateOfJob;
    }
}