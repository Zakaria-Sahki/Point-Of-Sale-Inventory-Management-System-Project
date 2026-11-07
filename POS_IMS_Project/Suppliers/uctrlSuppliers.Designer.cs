namespace POS_IMS_Project
{
    partial class uctrlSuppliers
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
            this.components = new System.ComponentModel.Container();
            this.btnFindSupplier = new System.Windows.Forms.Button();
            this.btnAddNewSupplier = new System.Windows.Forms.Button();
            this.lblNumOfCustomers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.cmsSuppliers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.cmsSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindSupplier
            // 
            this.btnFindSupplier.BackColor = System.Drawing.Color.White;
            this.btnFindSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSupplier.Location = new System.Drawing.Point(1349, 206);
            this.btnFindSupplier.Name = "btnFindSupplier";
            this.btnFindSupplier.Size = new System.Drawing.Size(227, 57);
            this.btnFindSupplier.TabIndex = 24;
            this.btnFindSupplier.Text = "Find Supplier";
            this.btnFindSupplier.UseVisualStyleBackColor = false;
            this.btnFindSupplier.Click += new System.EventHandler(this.btnFindSupplier_Click);
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnAddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSupplier.Location = new System.Drawing.Point(1349, 127);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(227, 57);
            this.btnAddNewSupplier.TabIndex = 23;
            this.btnAddNewSupplier.Text = "+ Add Supplier";
            this.btnAddNewSupplier.UseVisualStyleBackColor = false;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // lblNumOfCustomers
            // 
            this.lblNumOfCustomers.AutoSize = true;
            this.lblNumOfCustomers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfCustomers.Location = new System.Drawing.Point(340, 114);
            this.lblNumOfCustomers.Name = "lblNumOfCustomers";
            this.lblNumOfCustomers.Size = new System.Drawing.Size(181, 24);
            this.lblNumOfCustomers.TabIndex = 22;
            this.lblNumOfCustomers.Text = " Suppliers registered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Suppliers Management";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.ContextMenuStrip = this.cmsSuppliers;
            this.dgvSuppliers.Location = new System.Drawing.Point(32, 307);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 62;
            this.dgvSuppliers.RowTemplate.Height = 28;
            this.dgvSuppliers.Size = new System.Drawing.Size(1564, 506);
            this.dgvSuppliers.TabIndex = 20;
            // 
            // cmsSuppliers
            // 
            this.cmsSuppliers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSuppliers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSupplierToolStripMenuItem,
            this.deleteSupplierToolStripMenuItem,
            this.supplierInfoToolStripMenuItem});
            this.cmsSuppliers.Name = "cmsSuppliers";
            this.cmsSuppliers.Size = new System.Drawing.Size(213, 100);
            // 
            // updateSupplierToolStripMenuItem
            // 
            this.updateSupplierToolStripMenuItem.Name = "updateSupplierToolStripMenuItem";
            this.updateSupplierToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.updateSupplierToolStripMenuItem.Text = "Update Supplier";
            this.updateSupplierToolStripMenuItem.Click += new System.EventHandler(this.updateSupplierToolStripMenuItem_Click);
            // 
            // deleteSupplierToolStripMenuItem
            // 
            this.deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            this.deleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            this.deleteSupplierToolStripMenuItem.Click += new System.EventHandler(this.deleteSupplierToolStripMenuItem_Click);
            // 
            // supplierInfoToolStripMenuItem
            // 
            this.supplierInfoToolStripMenuItem.Name = "supplierInfoToolStripMenuItem";
            this.supplierInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.supplierInfoToolStripMenuItem.Text = "Supplier Info";
            this.supplierInfoToolStripMenuItem.Click += new System.EventHandler(this.supplierInfoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.supply_chain;
            this.pictureBox1.Location = new System.Drawing.Point(80, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // uctrlSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFindSupplier);
            this.Controls.Add(this.btnAddNewSupplier);
            this.Controls.Add(this.lblNumOfCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "uctrlSuppliers";
            this.Size = new System.Drawing.Size(1631, 895);
            this.Load += new System.EventHandler(this.uctrlSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.cmsSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindSupplier;
        private System.Windows.Forms.Button btnAddNewSupplier;
        private System.Windows.Forms.Label lblNumOfCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.ContextMenuStrip cmsSuppliers;
        private System.Windows.Forms.ToolStripMenuItem updateSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInfoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
