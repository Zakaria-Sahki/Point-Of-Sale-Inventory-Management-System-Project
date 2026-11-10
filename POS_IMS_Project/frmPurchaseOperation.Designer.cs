namespace POS_IMS_Project
{
    partial class frmPurchaseOperation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSelectSupplier = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbPurchaseInfo = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantityReceive = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlFindSupplier1 = new POS_IMS_Project.uctrlFindSupplier();
            this.tabControl1.SuspendLayout();
            this.tpSelectSupplier.SuspendLayout();
            this.tbPurchaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSelectSupplier);
            this.tabControl1.Controls.Add(this.tbPurchaseInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 721);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSelectSupplier
            // 
            this.tpSelectSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.tpSelectSupplier.Controls.Add(this.btnNext);
            this.tpSelectSupplier.Controls.Add(this.uctrlFindSupplier1);
            this.tpSelectSupplier.Location = new System.Drawing.Point(4, 29);
            this.tpSelectSupplier.Name = "tpSelectSupplier";
            this.tpSelectSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectSupplier.Size = new System.Drawing.Size(1071, 688);
            this.tpSelectSupplier.TabIndex = 0;
            this.tpSelectSupplier.Text = "Select Supplier";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(818, 620);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(212, 45);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbPurchaseInfo
            // 
            this.tbPurchaseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.tbPurchaseInfo.Controls.Add(this.btnCancel);
            this.tbPurchaseInfo.Controls.Add(this.btnPurchase);
            this.tbPurchaseInfo.Controls.Add(this.lblUnitPrice);
            this.tbPurchaseInfo.Controls.Add(this.label7);
            this.tbPurchaseInfo.Controls.Add(this.lblProductName);
            this.tbPurchaseInfo.Controls.Add(this.label5);
            this.tbPurchaseInfo.Controls.Add(this.lblTotalPrice);
            this.tbPurchaseInfo.Controls.Add(this.label2);
            this.tbPurchaseInfo.Controls.Add(this.label1);
            this.tbPurchaseInfo.Controls.Add(this.txtQuantityReceive);
            this.tbPurchaseInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPurchaseInfo.Name = "tbPurchaseInfo";
            this.tbPurchaseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPurchaseInfo.Size = new System.Drawing.Size(1071, 688);
            this.tbPurchaseInfo.TabIndex = 1;
            this.tbPurchaseInfo.Text = "Purchase Info";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(630, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 47);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(202, 573);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(218, 47);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(576, 212);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(72, 35);
            this.lblUnitPrice.TabIndex = 7;
            this.lblUnitPrice.Text = "[xxx]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(394, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unit Price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblProductName.Location = new System.Drawing.Point(576, 121);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 35);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "[xxx]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(341, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Name:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(576, 402);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 35);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "[xxx]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(386, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(279, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity to Receive:";
            // 
            // txtQuantityReceive
            // 
            this.txtQuantityReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantityReceive.Enabled = false;
            this.txtQuantityReceive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityReceive.Location = new System.Drawing.Point(582, 302);
            this.txtQuantityReceive.MaxLength = 6;
            this.txtQuantityReceive.Name = "txtQuantityReceive";
            this.txtQuantityReceive.Size = new System.Drawing.Size(266, 37);
            this.txtQuantityReceive.TabIndex = 0;
            this.txtQuantityReceive.TextChanged += new System.EventHandler(this.txtQuantityReceive_TextChanged);
            this.txtQuantityReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityReceive_KeyPress);
            this.txtQuantityReceive.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantityReceive_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlFindSupplier1
            // 
            this.uctrlFindSupplier1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.uctrlFindSupplier1.Location = new System.Drawing.Point(6, 6);
            this.uctrlFindSupplier1.Name = "uctrlFindSupplier1";
            this.uctrlFindSupplier1.Size = new System.Drawing.Size(1054, 585);
            this.uctrlFindSupplier1.TabIndex = 0;
            // 
            // frmPurchaseOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 766);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPurchaseOperation";
            this.Text = "frmPurchaseOperation";
            this.Load += new System.EventHandler(this.frmPurchaseOperation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSelectSupplier.ResumeLayout(false);
            this.tbPurchaseInfo.ResumeLayout(false);
            this.tbPurchaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSelectSupplier;
        private System.Windows.Forms.TabPage tbPurchaseInfo;
        private uctrlFindSupplier uctrlFindSupplier1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtQuantityReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}