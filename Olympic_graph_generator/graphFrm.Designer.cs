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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.lblYaxis = new RotatedLabel();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPanel.Location = new System.Drawing.Point(32, 47);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(600, 600);
            this.lblPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(151, 695);
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
            this.lblXaxis.Location = new System.Drawing.Point(189, 647);
            this.lblXaxis.Name = "lblXaxis";
            this.lblXaxis.Size = new System.Drawing.Size(300, 25);
            this.lblXaxis.TabIndex = 2;
            this.lblXaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXaxis.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(189, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(450, 695);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(98, 40);
            this.btnCreateFile.TabIndex = 5;
            this.btnCreateFile.Text = "Create Image File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // lblYaxis
            // 
            this.lblYaxis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYaxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYaxis.Location = new System.Drawing.Point(6, 186);
            this.lblYaxis.Name = "lblYaxis";
            this.lblYaxis.NewText = null;
            this.lblYaxis.Size = new System.Drawing.Size(25, 300);
            this.lblYaxis.TabIndex = 6;
            this.lblYaxis.Visible = false;
            // 
            // grpGraph
            // 
            this.grpGraph.BackColor = System.Drawing.SystemColors.Control;
            this.grpGraph.Controls.Add(this.lblYaxis);
            this.grpGraph.Controls.Add(this.lblPanel);
            this.grpGraph.Controls.Add(this.lblXaxis);
            this.grpGraph.Controls.Add(this.lblTitle);
            this.grpGraph.Location = new System.Drawing.Point(12, 12);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(679, 676);
            this.grpGraph.TabIndex = 7;
            this.grpGraph.TabStop = false;
            // 
            // btnGraph
            // 
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(299, 695);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(98, 40);
            this.btnGraph.TabIndex = 8;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // graphFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 747);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpGraph);
            this.Name = "graphFrm";
            this.Text = "Olympic Graph Generator";
            this.Load += new System.EventHandler(this.graphFrm_Load);
            this.grpGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblXaxis;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateFile;
        private RotatedLabel lblYaxis;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}