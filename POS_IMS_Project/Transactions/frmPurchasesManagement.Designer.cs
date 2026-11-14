namespace POS_IMS_Project.Transactions
{
    partial class frmPurchasesManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchByFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFitlerType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPurchaseInvoices = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsPurchaseInvoices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.purchaseInvoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsPurchaseInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1268, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "End date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(922, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "Start date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(1396, 264);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(172, 34);
            this.dtpEndDate.TabIndex = 46;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(1060, 264);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 34);
            this.dtpStartDate.TabIndex = 45;
            // 
            // txtSearchByFilter
            // 
            this.txtSearchByFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByFilter.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtSearchByFilter.Location = new System.Drawing.Point(491, 264);
            this.txtSearchByFilter.Name = "txtSearchByFilter";
            this.txtSearchByFilter.Size = new System.Drawing.Size(331, 34);
            this.txtSearchByFilter.TabIndex = 44;
            this.txtSearchByFilter.TextChanged += new System.EventHandler(this.txtSearchByFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(78, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filter Type:";
            // 
            // cbFitlerType
            // 
            this.cbFitlerType.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFitlerType.FormattingEnabled = true;
            this.cbFitlerType.Items.AddRange(new object[] {
            "None",
            "Username",
            "SupplierID",
            "CompanyName"});
            this.cbFitlerType.Location = new System.Drawing.Point(219, 264);
            this.cbFitlerType.Name = "cbFitlerType";
            this.cbFitlerType.Size = new System.Drawing.Size(244, 35);
            this.cbFitlerType.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 64);
            this.label1.TabIndex = 40;
            this.label1.Text = "Purchase Invoices";
            // 
            // dgvPurchaseInvoices
            // 
            this.dgvPurchaseInvoices.AllowUserToAddRows = false;
            this.dgvPurchaseInvoices.AllowUserToDeleteRows = false;
            this.dgvPurchaseInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseInvoices.Location = new System.Drawing.Point(39, 336);
            this.dgvPurchaseInvoices.Name = "dgvPurchaseInvoices";
            this.dgvPurchaseInvoices.ReadOnly = true;
            this.dgvPurchaseInvoices.RowHeadersWidth = 62;
            this.dgvPurchaseInvoices.RowTemplate.Height = 28;
            this.dgvPurchaseInvoices.Size = new System.Drawing.Size(1566, 503);
            this.dgvPurchaseInvoices.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.purchasing;
            this.pictureBox1.Location = new System.Drawing.Point(508, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // cmsPurchaseInvoices
            // 
            this.cmsPurchaseInvoices.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPurchaseInvoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInvoiceDetailsToolStripMenuItem});
            this.cmsPurchaseInvoices.Name = "cmsPurchaseInvoices";
            this.cmsPurchaseInvoices.Size = new System.Drawing.Size(274, 36);
            // 
            // purchaseInvoiceDetailsToolStripMenuItem
            // 
            this.purchaseInvoiceDetailsToolStripMenuItem.Name = "purchaseInvoiceDetailsToolStripMenuItem";
            this.purchaseInvoiceDetailsToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.purchaseInvoiceDetailsToolStripMenuItem.Text = "Purchase Invoice Details";
            this.purchaseInvoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.purchaseInvoiceDetailsToolStripMenuItem_Click);
            // 
            // frmPurchasesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.dgvPurchaseInvoices);
            this.Name = "frmPurchasesManagement";
            this.Text = "Purchase Management";
            this.Load += new System.EventHandler(this.frmPurchasesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsPurchaseInvoices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtSearchByFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFitlerType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPurchaseInvoices;
        private System.Windows.Forms.ContextMenuStrip cmsPurchaseInvoices;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceDetailsToolStripMenuItem;
    }
}