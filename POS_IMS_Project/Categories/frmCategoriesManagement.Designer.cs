namespace POS_IMS_Project
{
    partial class frmCategoriesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriesManagement));
            this.lblNumberOfCategories = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFindCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.cmsCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.cmsCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfCategories
            // 
            this.lblNumberOfCategories.AutoSize = true;
            this.lblNumberOfCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCategories.Location = new System.Drawing.Point(49, 204);
            this.lblNumberOfCategories.Name = "lblNumberOfCategories";
            this.lblNumberOfCategories.Size = new System.Drawing.Size(226, 29);
            this.lblNumberOfCategories.TabIndex = 12;
            this.lblNumberOfCategories.Text = "Categories Registered";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(872, 588);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFindCategory
            // 
            this.btnFindCategory.BackColor = System.Drawing.Color.White;
            this.btnFindCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCategory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCategory.Location = new System.Drawing.Point(699, 198);
            this.btnFindCategory.Name = "btnFindCategory";
            this.btnFindCategory.Size = new System.Drawing.Size(154, 40);
            this.btnFindCategory.TabIndex = 10;
            this.btnFindCategory.Text = "Find Category";
            this.btnFindCategory.UseVisualStyleBackColor = false;
            this.btnFindCategory.Click += new System.EventHandler(this.btnFindCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(872, 198);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(154, 40);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.ContextMenuStrip = this.cmsCategories;
            this.dgvCategories.Location = new System.Drawing.Point(29, 260);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersWidth = 62;
            this.dgvCategories.RowTemplate.Height = 28;
            this.dgvCategories.Size = new System.Drawing.Size(1008, 286);
            this.dgvCategories.TabIndex = 8;
            // 
            // cmsCategories
            // 
            this.cmsCategories.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem,
            this.categoryInfoToolStripMenuItem});
            this.cmsCategories.Name = "cmsCategories";
            this.cmsCategories.Size = new System.Drawing.Size(220, 100);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.deleteCategoryToolStripMenuItem.Text = "Delete Category";
            this.deleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteCategoryToolStripMenuItem_Click);
            // 
            // categoryInfoToolStripMenuItem
            // 
            this.categoryInfoToolStripMenuItem.Name = "categoryInfoToolStripMenuItem";
            this.categoryInfoToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.categoryInfoToolStripMenuItem.Text = "Category Info";
            this.categoryInfoToolStripMenuItem.Click += new System.EventHandler(this.categoryInfoToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 59);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Category Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.classification;
            this.pictureBox1.Location = new System.Drawing.Point(173, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmCategoriesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1066, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumberOfCategories);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategoriesManagement";
            this.Text = "Categories Management";
            this.Load += new System.EventHandler(this.frmCategoriesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.cmsCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cmsCategories;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryInfoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}