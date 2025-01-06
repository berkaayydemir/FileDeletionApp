namespace FileDeletionApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSchedule;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(124, 15);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Tarih ve Saat Seçiniz:";
             
            this.dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(15, 33);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(350, 23);
            this.dtpDateTime.TabIndex = 1;
             
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 69);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(63, 15);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Dosya Yolu:";
             
            this.txtFilePath.Location = new System.Drawing.Point(15, 87);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(350, 23);
            this.txtFilePath.TabIndex = 3;
             
            this.btnBrowse.Location = new System.Drawing.Point(371, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Gözat";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
             
            this.btnSchedule.Location = new System.Drawing.Point(15, 130);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(431, 30);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Silme İşlemini Planla";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 180);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.lblDateTime);
            this.Name = "MainForm";
            this.Text = "File Deletion App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}