namespace Olympic_graph_generator
{
    partial class graphFrm
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
            this.lblPanel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblXaxis = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYaxis = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPanel.Location = new System.Drawing.Point(50, 50);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(400, 400);
            this.lblPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 534);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblXaxis
            // 
            this.lblXaxis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblXaxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXaxis.Location = new System.Drawing.Point(100, 458);
            this.lblXaxis.Name = "lblXaxis";
            this.lblXaxis.Size = new System.Drawing.Size(300, 25);
            this.lblXaxis.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Location = new System.Drawing.Point(100, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYaxis
            // 
            this.lblYaxis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYaxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYaxis.Location = new System.Drawing.Point(17, 100);
            this.lblYaxis.Name = "lblYaxis";
            this.lblYaxis.Size = new System.Drawing.Size(25, 300);
            this.lblYaxis.TabIndex = 4;
            this.lblYaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYaxis.Paint += new System.Windows.Forms.PaintEventHandler(this.lblYaxis_Paint);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(352, 534);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(98, 40);
            this.btnCreateFile.TabIndex = 5;
            this.btnCreateFile.Text = "Create Image File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // graphFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 586);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.lblYaxis);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblXaxis);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPanel);
            this.Name = "graphFrm";
            this.Text = "Olympic Graph Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblXaxis;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYaxis;
        private System.Windows.Forms.Button btnCreateFile;
    }
}