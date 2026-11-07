namespace POS_IMS_Project
{
    partial class uctrlDraftedBaskets
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblDraftTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCountProducts = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Moccasin;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRestore.Location = new System.Drawing.Point(801, 33);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(214, 51);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblDraftTitle
            // 
            this.lblDraftTitle.AutoSize = true;
            this.lblDraftTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftTitle.Location = new System.Drawing.Point(110, 34);
            this.lblDraftTitle.Name = "lblDraftTitle";
            this.lblDraftTitle.Size = new System.Drawing.Size(221, 49);
            this.lblDraftTitle.TabIndex = 4;
            this.lblDraftTitle.Text = "Draft (Time)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblDate.Location = new System.Drawing.Point(86, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(217, 27);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "xx/xx/xxxx, x:xx:xx PM";
            // 
            // lblCountProducts
            // 
            this.lblCountProducts.AutoSize = true;
            this.lblCountProducts.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountProducts.Location = new System.Drawing.Point(403, 117);
            this.lblCountProducts.Name = "lblCountProducts";
            this.lblCountProducts.Size = new System.Drawing.Size(121, 27);
            this.lblCountProducts.TabIndex = 7;
            this.lblCountProducts.Text = "x Product(s)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POS_IMS_Project.Properties.Resources.icons8_basket_24;
            this.pictureBox4.Location = new System.Drawing.Point(351, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_IMS_Project.Properties.Resources.icons8_clock_50;
            this.pictureBox3.Location = new System.Drawing.Point(38, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_IMS_Project.Properties.Resources.icons8_bookmark_60;
            this.pictureBox2.Location = new System.Drawing.Point(38, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDelete.Image = global::POS_IMS_Project.Properties.Resources.icons8_trash_24;
            this.pbDelete.Location = new System.Drawing.Point(1059, 37);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(46, 42);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 2;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(815, 115);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(186, 29);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "xxxxxxxxx.xx DZD";
            // 
            // uctrlDraftedBaskets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblCountProducts);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDraftTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.btnRestore);
            this.Name = "uctrlDraftedBaskets";
            this.Size = new System.Drawing.Size(1148, 189);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDraftTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCountProducts;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}
