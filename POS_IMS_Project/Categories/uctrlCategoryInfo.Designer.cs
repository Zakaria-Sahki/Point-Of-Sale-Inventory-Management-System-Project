namespace POS_IMS_Project
{
    partial class uctrlCategoryInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxIsActive = new System.Windows.Forms.CheckBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.linklblEditCategory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.Location = new System.Drawing.Point(233, 39);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(56, 27);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "[xxx]";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(233, 106);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(56, 27);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "[xxx]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category Description:";
            // 
            // cboxIsActive
            // 
            this.cboxIsActive.AutoSize = true;
            this.cboxIsActive.Checked = true;
            this.cboxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsActive.Enabled = false;
            this.cboxIsActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsActive.Location = new System.Drawing.Point(547, 36);
            this.cboxIsActive.Name = "cboxIsActive";
            this.cboxIsActive.Size = new System.Drawing.Size(122, 33);
            this.cboxIsActive.TabIndex = 5;
            this.cboxIsActive.Text = "Is Active";
            this.cboxIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryDescription.Enabled = false;
            this.txtCategoryDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(42, 226);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(729, 134);
            this.txtCategoryDescription.TabIndex = 6;
            // 
            // linklblEditCategory
            // 
            this.linklblEditCategory.AutoSize = true;
            this.linklblEditCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblEditCategory.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblEditCategory.Location = new System.Drawing.Point(547, 172);
            this.linklblEditCategory.Name = "linklblEditCategory";
            this.linklblEditCategory.Size = new System.Drawing.Size(146, 29);
            this.linklblEditCategory.TabIndex = 7;
            this.linklblEditCategory.TabStop = true;
            this.linklblEditCategory.Text = "Edit Category";
            this.linklblEditCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblEditCategory_LinkClicked);
            // 
            // uctrlCategoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.linklblEditCategory);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.cboxIsActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.label1);
            this.Name = "uctrlCategoryInfo";
            this.Size = new System.Drawing.Size(813, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cboxIsActive;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.LinkLabel linklblEditCategory;
    }
}
