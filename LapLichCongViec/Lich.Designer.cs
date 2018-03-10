namespace LapLichCongViec
{
    partial class Lich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lich));
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnday = new System.Windows.Forms.Panel();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numNotify = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotify)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Lịch công việc";
            this.Notify.Visible = true;
            // 
            // pnday
            // 
            this.pnday.Location = new System.Drawing.Point(81, 4);
            this.pnday.Name = "pnday";
            this.pnday.Size = new System.Drawing.Size(560, 240);
            this.pnday.TabIndex = 0;
            // 
            // tmNotify
            // 
            this.tmNotify.Interval = 3000;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(647, 0);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(75, 23);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNextMonth);
            this.panel2.Controls.Add(this.btnSunday);
            this.panel2.Controls.Add(this.btnSaturday);
            this.panel2.Controls.Add(this.btnFriday);
            this.panel2.Controls.Add(this.btnThursday);
            this.panel2.Controls.Add(this.btnWednesday);
            this.panel2.Controls.Add(this.btnTuesday);
            this.panel2.Controls.Add(this.btnMonday);
            this.panel2.Controls.Add(this.btnPrevMonth);
            this.panel2.Location = new System.Drawing.Point(1, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 25);
            this.panel2.TabIndex = 4;
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(566, 0);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 23);
            this.btnSunday.TabIndex = 7;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(485, 0);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 23);
            this.btnSaturday.TabIndex = 6;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriday.Location = new System.Drawing.Point(404, 0);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 23);
            this.btnFriday.TabIndex = 5;
            this.btnFriday.Text = "Thứ sáu";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(323, 0);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 23);
            this.btnThursday.TabIndex = 4;
            this.btnThursday.Text = "Thứ năm";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(242, 0);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 23);
            this.btnWednesday.TabIndex = 3;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(162, 0);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 23);
            this.btnTuesday.TabIndex = 2;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(81, 0);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 23);
            this.btnMonday.TabIndex = 1;
            this.btnMonday.Text = "Thứ hai";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(0, 0);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(75, 23);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.Text = "Tháng trước";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            // 
            // cbNotify
            // 
            this.cbNotify.AutoSize = true;
            this.cbNotify.Location = new System.Drawing.Point(117, 10);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(78, 17);
            this.cbNotify.TabIndex = 0;
            this.cbNotify.Text = "Thông báo";
            this.cbNotify.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phút";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(526, 9);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(297, 10);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(214, 20);
            this.datetime.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.numNotify);
            this.panel1.Controls.Add(this.cbNotify);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 37);
            this.panel1.TabIndex = 3;
            // 
            // numNotify
            // 
            this.numNotify.Enabled = false;
            this.numNotify.Location = new System.Drawing.Point(201, 9);
            this.numNotify.Name = "numNotify";
            this.numNotify.Size = new System.Drawing.Size(55, 20);
            this.numNotify.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnday);
            this.panel3.Location = new System.Drawing.Point(1, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 249);
            this.panel3.TabIndex = 5;
            // 
            // Lich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 323);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Lich";
            this.Text = "Lịch công việc";
            this.Load += new System.EventHandler(this.Lich_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotify)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.Panel pnday;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numNotify;
        private System.Windows.Forms.Panel panel3;
    }
}

