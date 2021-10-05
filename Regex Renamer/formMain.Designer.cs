using CustomUI.Controls;

namespace Regex_Renamer
{
    partial class formMain
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
            this.labelFolder = new CustomUI.Controls.CustomLabel();
            this.labelRegex = new CustomUI.Controls.CustomLabel();
            this.textBoxFolder = new CustomUI.Controls.CustomTextBox();
            this.textBoxRegex = new CustomUI.Controls.CustomTextBox();
            this.buttonMultipleRename = new CustomUI.Controls.CustomButton();
            this.groupBox1 = new CustomUI.Controls.CustomGroupBox();
            this.checkBoxClearUnderscore = new CustomUI.Controls.CustomCheckBox();
            this.textBoxReplace = new CustomUI.Controls.CustomTextBox();
            this.labelReplace = new CustomUI.Controls.CustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxClearDash = new CustomUI.Controls.CustomCheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelFolder.Location = new System.Drawing.Point(14, 22);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(36, 13);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folder";
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelRegex.Location = new System.Drawing.Point(14, 48);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(41, 13);
            this.labelRegex.TabIndex = 1;
            this.labelRegex.Text = "Pattern";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxFolder.Location = new System.Drawing.Point(67, 19);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(381, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxRegex.Location = new System.Drawing.Point(67, 45);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(381, 20);
            this.textBoxRegex.TabIndex = 3;
            this.textBoxRegex.Text = "^(?<num>[0-9]{2})\\. (?<name>.*)(?<ext>\\..{3,4})$";
            // 
            // buttonMultipleRename
            // 
            this.buttonMultipleRename.Location = new System.Drawing.Point(6, 136);
            this.buttonMultipleRename.Name = "buttonMultipleRename";
            this.buttonMultipleRename.Padding = new System.Windows.Forms.Padding(5);
            this.buttonMultipleRename.Size = new System.Drawing.Size(442, 23);
            this.buttonMultipleRename.TabIndex = 4;
            this.buttonMultipleRename.Text = "Multiple rename";
            this.buttonMultipleRename.Click += new System.EventHandler(this.buttonMultipleRename_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.checkBoxClearDash);
            this.groupBox1.Controls.Add(this.checkBoxClearUnderscore);
            this.groupBox1.Controls.Add(this.textBoxReplace);
            this.groupBox1.Controls.Add(this.labelReplace);
            this.groupBox1.Controls.Add(this.textBoxFolder);
            this.groupBox1.Controls.Add(this.buttonMultipleRename);
            this.groupBox1.Controls.Add(this.labelFolder);
            this.groupBox1.Controls.Add(this.textBoxRegex);
            this.groupBox1.Controls.Add(this.labelRegex);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxClearUnderscore
            // 
            this.checkBoxClearUnderscore.Location = new System.Drawing.Point(17, 97);
            this.checkBoxClearUnderscore.Name = "checkBoxClearUnderscore";
            this.checkBoxClearUnderscore.Size = new System.Drawing.Size(158, 17);
            this.checkBoxClearUnderscore.TabIndex = 7;
            this.checkBoxClearUnderscore.Text = "Clear underscore on names";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxReplace.Location = new System.Drawing.Point(67, 71);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(381, 20);
            this.textBoxReplace.TabIndex = 6;
            this.textBoxReplace.Text = "${num} - ${name}${ext}";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelReplace.Location = new System.Drawing.Point(14, 74);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(47, 13);
            this.labelReplace.TabIndex = 5;
            this.labelReplace.Text = "Replace";
            // 
            // customCheckBoxClearDash
            // 
            this.checkBoxClearDash.Location = new System.Drawing.Point(181, 97);
            this.checkBoxClearDash.Name = "customCheckBoxClearDash";
            this.checkBoxClearDash.Size = new System.Drawing.Size(125, 17);
            this.checkBoxClearDash.TabIndex = 8;
            this.checkBoxClearDash.Text = "Clear dash on names";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 199);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 170);
            this.Name = "formMain";
            this.Text = "Regex Renamer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CustomLabel labelFolder;
        private CustomUI.Controls.CustomLabel labelRegex;
        private CustomUI.Controls.CustomTextBox textBoxFolder;
        private CustomUI.Controls.CustomTextBox textBoxRegex;
        private CustomUI.Controls.CustomButton buttonMultipleRename;
        private CustomUI.Controls.CustomGroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomUI.Controls.CustomTextBox textBoxReplace;
        private CustomUI.Controls.CustomLabel labelReplace;
        private CustomCheckBox checkBoxClearUnderscore;
        private CustomCheckBox checkBoxClearDash;
    }
}

