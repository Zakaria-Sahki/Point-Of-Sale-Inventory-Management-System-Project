namespace POS_IMS_Project
{
    partial class frmAddEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCustomer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbctrlAddEditCustomer = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.uctrlFindingPerson1 = new POS_IMS_Project.uctrlFindingPerson();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtTotalSpent = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.cBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbctrlAddEditCustomer.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(341, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Customer";
            // 
            // tbctrlAddEditCustomer
            // 
            this.tbctrlAddEditCustomer.Controls.Add(this.tabPersonInfo);
            this.tbctrlAddEditCustomer.Controls.Add(this.tabCustomerInfo);
            this.tbctrlAddEditCustomer.Location = new System.Drawing.Point(12, 164);
            this.tbctrlAddEditCustomer.Name = "tbctrlAddEditCustomer";
            this.tbctrlAddEditCustomer.SelectedIndex = 0;
            this.tbctrlAddEditCustomer.Size = new System.Drawing.Size(1039, 567);
            this.tbctrlAddEditCustomer.TabIndex = 1;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.uctrlFindingPerson1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1031, 534);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(820, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 55);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uctrlFindingPerson1
            // 
            this.uctrlFindingPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.uctrlFindingPerson1.Location = new System.Drawing.Point(6, 6);
            this.uctrlFindingPerson1.Name = "uctrlFindingPerson1";
            this.uctrlFindingPerson1.Size = new System.Drawing.Size(1013, 411);
            this.uctrlFindingPerson1.TabIndex = 0;
            this.uctrlFindingPerson1.OnPersonSelected += new System.Action<int>(this.uctrlFindingPerson1_OnPersonSelected);
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.tabCustomerInfo.Controls.Add(this.lblCustomerID);
            this.tabCustomerInfo.Controls.Add(this.txtTotalSpent);
            this.tabCustomerInfo.Controls.Add(this.txtNotes);
            this.tabCustomerInfo.Controls.Add(this.txtPoints);
            this.tabCustomerInfo.Controls.Add(this.txtCredits);
            this.tabCustomerInfo.Controls.Add(this.cBoxIsActive);
            this.tabCustomerInfo.Controls.Add(this.label5);
            this.tabCustomerInfo.Controls.Add(this.label4);
            this.tabCustomerInfo.Controls.Add(this.label3);
            this.tabCustomerInfo.Controls.Add(this.label2);
            this.tabCustomerInfo.Controls.Add(this.label1);
            this.tabCustomerInfo.Location = new System.Drawing.Point(4, 29);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerInfo.Size = new System.Drawing.Size(1031, 534);
            this.tabCustomerInfo.TabIndex = 1;
            this.tabCustomerInfo.Text = "Customer Info";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(220, 57);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(49, 24);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "[xxx]";
            // 
            // txtTotalSpent
            // 
            this.txtTotalSpent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSpent.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSpent.Location = new System.Drawing.Point(372, 145);
            this.txtTotalSpent.Name = "txtTotalSpent";
            this.txtTotalSpent.Size = new System.Drawing.Size(259, 34);
            this.txtTotalSpent.TabIndex = 9;
            this.txtTotalSpent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalSpent_KeyPress);
            this.txtTotalSpent.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalSpent_Validating);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(169, 346);
            this.txtNotes.MaxLength = 700;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(664, 130);
            this.txtNotes.TabIndex = 8;
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(372, 279);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(259, 34);
            this.txtPoints.TabIndex = 7;
            this.txtPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoints_KeyPress);
            this.txtPoints.Validating += new System.ComponentModel.CancelEventHandler(this.txtPoints_Validating);
            // 
            // txtCredits
            // 
            this.txtCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredits.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(372, 212);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(259, 34);
            this.txtCredits.TabIndex = 6;
            this.txtCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredits_KeyPress);
            this.txtCredits.Validating += new System.ComponentModel.CancelEventHandler(this.txtCredits_Validating);
            // 
            // cBoxIsActive
            // 
            this.cBoxIsActive.AutoSize = true;
            this.cBoxIsActive.Checked = true;
            this.cBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxIsActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxIsActive.Location = new System.Drawing.Point(741, 53);
            this.cBoxIsActive.Name = "cBoxIsActive";
            this.cBoxIsActive.Size = new System.Drawing.Size(117, 33);
            this.cBoxIsActive.TabIndex = 5;
            this.cBoxIsActive.Text = "IsActive";
            this.cBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TotalSpent:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(836, 770);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 55);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(607, 770);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 55);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1062, 871);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbctrlAddEditCustomer);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditCustomer";
            this.Text = "frmAddEditCustomer";
            this.Load += new System.EventHandler(this.frmAddEditCustomer_Load);
            this.tbctrlAddEditCustomer.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabCustomerInfo.ResumeLayout(false);
            this.tabCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbctrlAddEditCustomer;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private uctrlFindingPerson uctrlFindingPerson1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cBoxIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtTotalSpent;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}