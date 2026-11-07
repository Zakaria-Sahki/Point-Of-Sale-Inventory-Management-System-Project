namespace POS_IMS_Project
{
    partial class frmDraftScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpDrafts = new System.Windows.Forms.FlowLayoutPanel();
            this.pbImagePause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending Drafts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoices that were suspended and not completed yet.";
            // 
            // flpDrafts
            // 
            this.flpDrafts.AutoScroll = true;
            this.flpDrafts.BackColor = System.Drawing.Color.White;
            this.flpDrafts.Location = new System.Drawing.Point(24, 230);
            this.flpDrafts.Name = "flpDrafts";
            this.flpDrafts.Size = new System.Drawing.Size(1187, 410);
            this.flpDrafts.TabIndex = 3;
            // 
            // pbImagePause
            // 
            this.pbImagePause.Image = global::POS_IMS_Project.Properties.Resources.icons8_pause_96;
            this.pbImagePause.Location = new System.Drawing.Point(40, 34);
            this.pbImagePause.Name = "pbImagePause";
            this.pbImagePause.Size = new System.Drawing.Size(100, 100);
            this.pbImagePause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagePause.TabIndex = 1;
            this.pbImagePause.TabStop = false;
            // 
            // frmDraftScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 665);
            this.Controls.Add(this.flpDrafts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImagePause);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDraftScreen";
            this.Text = "frmDraftScreen";
            this.Load += new System.EventHandler(this.frmDraftScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagePause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpDrafts;
    }
}