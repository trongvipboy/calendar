namespace LapLichCongViec
{
    partial class CongViec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJob = new System.Windows.Forms.TextBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numToMinute = new System.Windows.Forms.NumericUpDown();
            this.numToHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numFromMinute = new System.Windows.Forms.NumericUpDown();
            this.numFromHour = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromHour)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(24, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(252, 20);
            this.txtJob.TabIndex = 1;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(3, 5);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(15, 14);
            this.cbDone.TabIndex = 0;
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numToMinute);
            this.panel2.Controls.Add(this.numToHour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numFromMinute);
            this.panel2.Controls.Add(this.numFromHour);
            this.panel2.Location = new System.Drawing.Point(283, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 24);
            this.panel2.TabIndex = 6;
            // 
            // numToMinute
            // 
            this.numToMinute.Location = new System.Drawing.Point(158, 3);
            this.numToMinute.Name = "numToMinute";
            this.numToMinute.Size = new System.Drawing.Size(39, 20);
            this.numToMinute.TabIndex = 4;
            // 
            // numToHour
            // 
            this.numToHour.Location = new System.Drawing.Point(117, 3);
            this.numToHour.Name = "numToHour";
            this.numToHour.Size = new System.Drawing.Size(35, 20);
            this.numToHour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến";
            // 
            // numFromMinute
            // 
            this.numFromMinute.Location = new System.Drawing.Point(41, 3);
            this.numFromMinute.Name = "numFromMinute";
            this.numFromMinute.Size = new System.Drawing.Size(39, 20);
            this.numFromMinute.TabIndex = 1;
            // 
            // numFromHour
            // 
            this.numFromHour.Location = new System.Drawing.Point(3, 3);
            this.numFromHour.Name = "numFromHour";
            this.numFromHour.Size = new System.Drawing.Size(35, 20);
            this.numFromHour.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.cbDone);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 24);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(482, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 24);
            this.panel3.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(54, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(48, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "CongViec";
            this.Size = new System.Drawing.Size(587, 31);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromHour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numToMinute;
        private System.Windows.Forms.NumericUpDown numToHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFromMinute;
        private System.Windows.Forms.NumericUpDown numFromHour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
