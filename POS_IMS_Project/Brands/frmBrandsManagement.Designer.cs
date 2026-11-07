namespace POS_IMS_Project
{
    partial class frmBrandsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrandsManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.cmsBrands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnFindBrand = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumberOfBrands = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.cmsBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Management";
            // 
            // dgvBrands
            // 
            this.dgvBrands.AllowUserToAddRows = false;
            this.dgvBrands.AllowUserToDeleteRows = false;
            this.dgvBrands.BackgroundColor = System.Drawing.Color.White;
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrands.ContextMenuStrip = this.cmsBrands;
            this.dgvBrands.Location = new System.Drawing.Point(30, 260);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.ReadOnly = true;
            this.dgvBrands.RowHeadersWidth = 62;
            this.dgvBrands.RowTemplate.Height = 28;
            this.dgvBrands.Size = new System.Drawing.Size(1008, 286);
            this.dgvBrands.TabIndex = 1;
            // 
            // cmsBrands
            // 
            this.cmsBrands.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsBrands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBrandToolStripMenuItem,
            this.deleteBrandToolStripMenuItem,
            this.brandInfoToolStripMenuItem});
            this.cmsBrands.Name = "cmsBrands";
            this.cmsBrands.Size = new System.Drawing.Size(194, 100);
            // 
            // updateBrandToolStripMenuItem
            // 
            this.updateBrandToolStripMenuItem.Name = "updateBrandToolStripMenuItem";
            this.updateBrandToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.updateBrandToolStripMenuItem.Text = "Update Brand";
            this.updateBrandToolStripMenuItem.Click += new System.EventHandler(this.updateBrandToolStripMenuItem_Click);
            // 
            // deleteBrandToolStripMenuItem
            // 
            this.deleteBrandToolStripMenuItem.Name = "deleteBrandToolStripMenuItem";
            this.deleteBrandToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.deleteBrandToolStripMenuItem.Text = "Delete Brand";
            this.deleteBrandToolStripMenuItem.Click += new System.EventHandler(this.deleteBrandToolStripMenuItem_Click);
            // 
            // brandInfoToolStripMenuItem
            // 
            this.brandInfoToolStripMenuItem.Name = "brandInfoToolStripMenuItem";
            this.brandInfoToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.brandInfoToolStripMenuItem.Text = "Brand Info";
            this.brandInfoToolStripMenuItem.Click += new System.EventHandler(this.brandInfoToolStripMenuItem_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.Location = new System.Drawing.Point(873, 198);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(154, 40);
            this.btnAddBrand.TabIndex = 2;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnFindBrand
            // 
            this.btnFindBrand.BackColor = System.Drawing.Color.White;
            this.btnFindBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBrand.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBrand.Location = new System.Drawing.Point(700, 198);
            this.btnFindBrand.Name = "btnFindBrand";
            this.btnFindBrand.Size = new System.Drawing.Size(154, 40);
            this.btnFindBrand.TabIndex = 3;
            this.btnFindBrand.Text = "Find Brand";
            this.btnFindBrand.UseVisualStyleBackColor = false;
            this.btnFindBrand.Click += new System.EventHandler(this.btnFindBrand_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(873, 588);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberOfBrands
            // 
            this.lblNumberOfBrands.AutoSize = true;
            this.lblNumberOfBrands.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBrands.Location = new System.Drawing.Point(50, 204);
            this.lblNumberOfBrands.Name = "lblNumberOfBrands";
            this.lblNumberOfBrands.Size = new System.Drawing.Size(190, 29);
            this.lblNumberOfBrands.TabIndex = 6;
            this.lblNumberOfBrands.Text = "Brands Registered";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.brand_image;
            this.pictureBox1.Location = new System.Drawing.Point(182, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBrandsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1066, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumberOfBrands);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.dgvBrands);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrandsManagement";
            this.Text = "frmBrandsManagement";
            this.Load += new System.EventHandler(this.frmBrandsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.cmsBrands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnFindBrand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsBrands;
        private System.Windows.Forms.ToolStripMenuItem updateBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandInfoToolStripMenuItem;
        private System.Windows.Forms.Label lblNumberOfBrands;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}