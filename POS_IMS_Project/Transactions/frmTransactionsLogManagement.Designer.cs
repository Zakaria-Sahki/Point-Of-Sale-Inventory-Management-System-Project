namespace POS_IMS_Project
{
    partial class frmTransactionsLogManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionsLogManagement));
            this.dgvTransactionsLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFitlerType = new System.Windows.Forms.ComboBox();
            this.txtSearchByFilter = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionsLog
            // 
            this.dgvTransactionsLog.AllowUserToAddRows = false;
            this.dgvTransactionsLog.AllowUserToDeleteRows = false;
            this.dgvTransactionsLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionsLog.Location = new System.Drawing.Point(40, 337);
            this.dgvTransactionsLog.Name = "dgvTransactionsLog";
            this.dgvTransactionsLog.ReadOnly = true;
            this.dgvTransactionsLog.RowHeadersWidth = 62;
            this.dgvTransactionsLog.RowTemplate.Height = 28;
            this.dgvTransactionsLog.Size = new System.Drawing.Size(1566, 503);
            this.dgvTransactionsLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Logs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.transaction_history;
            this.pictureBox1.Location = new System.Drawing.Point(509, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(79, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filter Type:";
            // 
            // cbFitlerType
            // 
            this.cbFitlerType.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFitlerType.FormattingEnabled = true;
            this.cbFitlerType.Items.AddRange(new object[] {
            "None",
            "Username",
            "ProductName",
            "TransactionType"});
            this.cbFitlerType.Location = new System.Drawing.Point(220, 265);
            this.cbFitlerType.Name = "cbFitlerType";
            this.cbFitlerType.Size = new System.Drawing.Size(244, 35);
            this.cbFitlerType.TabIndex = 22;
            // 
            // txtSearchByFilter
            // 
            this.txtSearchByFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByFilter.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtSearchByFilter.Location = new System.Drawing.Point(492, 265);
            this.txtSearchByFilter.Name = "txtSearchByFilter";
            this.txtSearchByFilter.Size = new System.Drawing.Size(331, 34);
            this.txtSearchByFilter.TabIndex = 24;
            this.txtSearchByFilter.TextChanged += new System.EventHandler(this.txtSearchByFilter_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(1061, 265);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 34);
            this.dtpStartDate.TabIndex = 25;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(1397, 265);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(172, 34);
            this.dtpEndDate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(923, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Start date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1269, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "End date:";
            // 
            // frmTransactionsLogManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1644, 875);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtSearchByFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFitlerType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransactionsLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransactionsLogManagement";
            this.Text = "Transactions Log Management";
            this.Load += new System.EventHandler(this.frmTransactionsLogManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionsLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFitlerType;
        private System.Windows.Forms.TextBox txtSearchByFilter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}