namespace Olympic_graph_generator
{
    partial class mainFrm
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
            this.grpGraphChoices = new System.Windows.Forms.GroupBox();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.radBar = new System.Windows.Forms.RadioButton();
            this.radPie = new System.Windows.Forms.RadioButton();
            this.lblPrompt1 = new System.Windows.Forms.Label();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblPrompt2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYaxis = new System.Windows.Forms.Label();
            this.lblPrompt3 = new System.Windows.Forms.Label();
            this.lblXaxis = new System.Windows.Forms.Label();
            this.lblPrompt4 = new System.Windows.Forms.Label();
            this.lblPrompt5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtItemData = new System.Windows.Forms.TextBox();
            this.lblPrompt9 = new System.Windows.Forms.Label();
            this.txtXaxis = new System.Windows.Forms.TextBox();
            this.lblPrompt6 = new System.Windows.Forms.Label();
            this.txtYaxis = new System.Windows.Forms.TextBox();
            this.lblPrompt7 = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblPromp8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPrompt10 = new System.Windows.Forms.Label();
            this.lblColorBox = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lblColorName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGraphChoices.SuspendLayout();
            this.grpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGraphChoices
            // 
            this.grpGraphChoices.Controls.Add(this.radLine);
            this.grpGraphChoices.Controls.Add(this.radBar);
            this.grpGraphChoices.Controls.Add(this.radPie);
            this.grpGraphChoices.Location = new System.Drawing.Point(15, 28);
            this.grpGraphChoices.Name = "grpGraphChoices";
            this.grpGraphChoices.Size = new System.Drawing.Size(121, 359);
            this.grpGraphChoices.TabIndex = 0;
            this.grpGraphChoices.TabStop = false;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(6, 59);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(77, 17);
            this.radLine.TabIndex = 2;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line Graph";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // radBar
            // 
            this.radBar.AutoSize = true;
            this.radBar.Location = new System.Drawing.Point(6, 36);
            this.radBar.Name = "radBar";
            this.radBar.Size = new System.Drawing.Size(73, 17);
            this.radBar.TabIndex = 1;
            this.radBar.TabStop = true;
            this.radBar.Text = "Bar Graph";
            this.radBar.UseVisualStyleBackColor = true;
            // 
            // radPie
            // 
            this.radPie.AutoSize = true;
            this.radPie.Location = new System.Drawing.Point(6, 13);
            this.radPie.Name = "radPie";
            this.radPie.Size = new System.Drawing.Size(68, 17);
            this.radPie.TabIndex = 0;
            this.radPie.TabStop = true;
            this.radPie.Text = "Pie Chart";
            this.radPie.UseVisualStyleBackColor = true;
            // 
            // lblPrompt1
            // 
            this.lblPrompt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt1.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt1.Name = "lblPrompt1";
            this.lblPrompt1.Size = new System.Drawing.Size(184, 23);
            this.lblPrompt1.TabIndex = 1;
            this.lblPrompt1.Text = "Choose one:";
            this.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(519, 71);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(313, 316);
            this.lstData.TabIndex = 2;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // lblPrompt2
            // 
            this.lblPrompt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt2.Location = new System.Drawing.Point(516, 12);
            this.lblPrompt2.Name = "lblPrompt2";
            this.lblPrompt2.Size = new System.Drawing.Size(39, 23);
            this.lblPrompt2.TabIndex = 3;
            this.lblPrompt2.Text = "Title:";
            this.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(556, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYaxis
            // 
            this.lblYaxis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaxis.Location = new System.Drawing.Point(560, 41);
            this.lblYaxis.Name = "lblYaxis";
            this.lblYaxis.Size = new System.Drawing.Size(106, 23);
            this.lblYaxis.TabIndex = 6;
            this.lblYaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrompt3
            // 
            this.lblPrompt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt3.Location = new System.Drawing.Point(516, 41);
            this.lblPrompt3.Name = "lblPrompt3";
            this.lblPrompt3.Size = new System.Drawing.Size(45, 23);
            this.lblPrompt3.TabIndex = 5;
            this.lblPrompt3.Text = "x-axis:";
            this.lblPrompt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblXaxis
            // 
            this.lblXaxis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblXaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXaxis.Location = new System.Drawing.Point(722, 41);
            this.lblXaxis.Name = "lblXaxis";
            this.lblXaxis.Size = new System.Drawing.Size(110, 23);
            this.lblXaxis.TabIndex = 8;
            this.lblXaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrompt4
            // 
            this.lblPrompt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt4.Location = new System.Drawing.Point(672, 41);
            this.lblPrompt4.Name = "lblPrompt4";
            this.lblPrompt4.Size = new System.Drawing.Size(47, 23);
            this.lblPrompt4.TabIndex = 7;
            this.lblPrompt4.Text = "y-axis:";
            this.lblPrompt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrompt5
            // 
            this.lblPrompt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt5.Location = new System.Drawing.Point(181, 35);
            this.lblPrompt5.Name = "lblPrompt5";
            this.lblPrompt5.Size = new System.Drawing.Size(74, 23);
            this.lblPrompt5.TabIndex = 9;
            this.lblPrompt5.Text = "Title:";
            this.lblPrompt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(261, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // txtItemData
            // 
            this.txtItemData.Location = new System.Drawing.Point(77, 47);
            this.txtItemData.Name = "txtItemData";
            this.txtItemData.Size = new System.Drawing.Size(207, 20);
            this.txtItemData.TabIndex = 12;
            // 
            // lblPrompt9
            // 
            this.lblPrompt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt9.Location = new System.Drawing.Point(11, 45);
            this.lblPrompt9.Name = "lblPrompt9";
            this.lblPrompt9.Size = new System.Drawing.Size(60, 23);
            this.lblPrompt9.TabIndex = 11;
            this.lblPrompt9.Text = "Data:";
            this.lblPrompt9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtXaxis
            // 
            this.txtXaxis.Location = new System.Drawing.Point(261, 63);
            this.txtXaxis.Name = "txtXaxis";
            this.txtXaxis.Size = new System.Drawing.Size(160, 20);
            this.txtXaxis.TabIndex = 14;
            // 
            // lblPrompt6
            // 
            this.lblPrompt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt6.Location = new System.Drawing.Point(181, 61);
            this.lblPrompt6.Name = "lblPrompt6";
            this.lblPrompt6.Size = new System.Drawing.Size(74, 23);
            this.lblPrompt6.TabIndex = 13;
            this.lblPrompt6.Text = "X-axis:";
            this.lblPrompt6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYaxis
            // 
            this.txtYaxis.Location = new System.Drawing.Point(261, 89);
            this.txtYaxis.Name = "txtYaxis";
            this.txtYaxis.Size = new System.Drawing.Size(160, 20);
            this.txtYaxis.TabIndex = 16;
            // 
            // lblPrompt7
            // 
            this.lblPrompt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt7.Location = new System.Drawing.Point(181, 87);
            this.lblPrompt7.Name = "lblPrompt7";
            this.lblPrompt7.Size = new System.Drawing.Size(74, 23);
            this.lblPrompt7.TabIndex = 15;
            this.lblPrompt7.Text = "Y-axis:";
            this.lblPrompt7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.btnAddItem);
            this.grpItem.Controls.Add(this.lblColorName);
            this.grpItem.Controls.Add(this.btnChangeColor);
            this.grpItem.Controls.Add(this.lblColorBox);
            this.grpItem.Controls.Add(this.lblPrompt10);
            this.grpItem.Controls.Add(this.txtItemName);
            this.grpItem.Controls.Add(this.lblPromp8);
            this.grpItem.Controls.Add(this.txtItemData);
            this.grpItem.Controls.Add(this.lblPrompt9);
            this.grpItem.Location = new System.Drawing.Point(184, 115);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(302, 216);
            this.grpItem.TabIndex = 17;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(77, 18);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(207, 20);
            this.txtItemName.TabIndex = 14;
            // 
            // lblPromp8
            // 
            this.lblPromp8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromp8.Location = new System.Drawing.Point(11, 16);
            this.lblPromp8.Name = "lblPromp8";
            this.lblPromp8.Size = new System.Drawing.Size(60, 23);
            this.lblPromp8.TabIndex = 13;
            this.lblPromp8.Text = "Name:";
            this.lblPromp8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(427, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 73);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPrompt10
            // 
            this.lblPrompt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt10.Location = new System.Drawing.Point(11, 80);
            this.lblPrompt10.Name = "lblPrompt10";
            this.lblPrompt10.Size = new System.Drawing.Size(60, 23);
            this.lblPrompt10.TabIndex = 15;
            this.lblPrompt10.Text = "Color:";
            this.lblPrompt10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColorBox
            // 
            this.lblColorBox.BackColor = System.Drawing.Color.Black;
            this.lblColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorBox.Location = new System.Drawing.Point(77, 80);
            this.lblColorBox.Name = "lblColorBox";
            this.lblColorBox.Size = new System.Drawing.Size(25, 25);
            this.lblColorBox.TabIndex = 16;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(225, 80);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(59, 23);
            this.btnChangeColor.TabIndex = 17;
            this.btnChangeColor.Text = "Change";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            // 
            // lblColorName
            // 
            this.lblColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorName.Location = new System.Drawing.Point(100, 80);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(119, 25);
            this.lblColorName.TabIndex = 18;
            this.lblColorName.Text = "Default: Random";
            this.lblColorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(380, 340);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 47);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create Graph";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(100, 175);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 33);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 47);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 399);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.txtYaxis);
            this.Controls.Add(this.lblPrompt7);
            this.Controls.Add(this.txtXaxis);
            this.Controls.Add(this.lblPrompt6);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblPrompt5);
            this.Controls.Add(this.lblXaxis);
            this.Controls.Add(this.lblPrompt4);
            this.Controls.Add(this.lblYaxis);
            this.Controls.Add(this.lblPrompt3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrompt2);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.lblPrompt1);
            this.Controls.Add(this.grpGraphChoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainFrm";
            this.Text = "Olympic Graph Generator";
            this.grpGraphChoices.ResumeLayout(false);
            this.grpGraphChoices.PerformLayout();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGraphChoices;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.RadioButton radBar;
        private System.Windows.Forms.RadioButton radPie;
        private System.Windows.Forms.Label lblPrompt1;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblPrompt2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYaxis;
        private System.Windows.Forms.Label lblPrompt3;
        private System.Windows.Forms.Label lblXaxis;
        private System.Windows.Forms.Label lblPrompt4;
        private System.Windows.Forms.Label lblPrompt5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtItemData;
        private System.Windows.Forms.Label lblPrompt9;
        private System.Windows.Forms.TextBox txtXaxis;
        private System.Windows.Forms.Label lblPrompt6;
        private System.Windows.Forms.TextBox txtYaxis;
        private System.Windows.Forms.Label lblPrompt7;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblPromp8;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label lblColorBox;
        private System.Windows.Forms.Label lblPrompt10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
    }
}