namespace POS_IMS_Project
{
    partial class uctrlFindingPerson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linklblEditPerson = new System.Windows.Forms.LinkLabel();
            this.uctrolPersonInfo_1 = new POS_IMS_Project.uctrolPersonInfo_();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linklblEditPerson);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonID);
            this.groupBox1.Controls.Add(this.uctrolPersonInfo_1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finding Person";
            // 
            // txtPersonID
            // 
            this.txtPersonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(194, 69);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(261, 37);
            this.txtPersonID.TabIndex = 1;
            this.txtPersonID.Validating += new System.ComponentModel.CancelEventHandler(this.txtPersonID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "PersonID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(538, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linklblEditPerson
            // 
            this.linklblEditPerson.AutoSize = true;
            this.linklblEditPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblEditPerson.ForeColor = System.Drawing.Color.Black;
            this.linklblEditPerson.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblEditPerson.LinkColor = System.Drawing.Color.Black;
            this.linklblEditPerson.Location = new System.Drawing.Point(797, 73);
            this.linklblEditPerson.Name = "linklblEditPerson";
            this.linklblEditPerson.Size = new System.Drawing.Size(127, 29);
            this.linklblEditPerson.TabIndex = 8;
            this.linklblEditPerson.TabStop = true;
            this.linklblEditPerson.Text = "Edit Person";
            this.linklblEditPerson.Visible = false;
            this.linklblEditPerson.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.linklblEditPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblEditPerson_LinkClicked);
            // 
            // uctrolPersonInfo_1
            // 
            this.uctrolPersonInfo_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.uctrolPersonInfo_1.Location = new System.Drawing.Point(33, 133);
            this.uctrolPersonInfo_1.Name = "uctrolPersonInfo_1";
            this.uctrolPersonInfo_1.Size = new System.Drawing.Size(933, 223);
            this.uctrolPersonInfo_1.TabIndex = 0;
            // 
            // uctrlFindingPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "uctrlFindingPerson";
            this.Size = new System.Drawing.Size(1013, 411);
            this.Load += new System.EventHandler(this.uctrlFindingPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private uctrolPersonInfo_ uctrolPersonInfo_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linklblEditPerson;
    }
}
