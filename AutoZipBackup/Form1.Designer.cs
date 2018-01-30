namespace AutoZipBackup
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fromButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.zippedCheck = new System.Windows.Forms.CheckBox();
            this.branchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fromButton
            // 
            this.fromButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromButton.Location = new System.Drawing.Point(347, 33);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(75, 23);
            this.fromButton.TabIndex = 0;
            this.fromButton.Text = "Browse";
            this.fromButton.UseVisualStyleBackColor = true;
            this.fromButton.Click += new System.EventHandler(this.fromButton_Click);
            // 
            // toButton
            // 
            this.toButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toButton.Location = new System.Drawing.Point(347, 62);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(75, 23);
            this.toButton.TabIndex = 1;
            this.toButton.Text = "Browse";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(12, 119);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(410, 23);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Make a backup";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // fromBox
            // 
            this.fromBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromBox.Location = new System.Drawing.Point(62, 35);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(279, 20);
            this.fromBox.TabIndex = 3;
            // 
            // toBox
            // 
            this.toBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toBox.Location = new System.Drawing.Point(62, 64);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(279, 20);
            this.toBox.TabIndex = 4;
            // 
            // zippedCheck
            // 
            this.zippedCheck.AutoSize = true;
            this.zippedCheck.Checked = true;
            this.zippedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zippedCheck.Location = new System.Drawing.Point(12, 12);
            this.zippedCheck.Name = "zippedCheck";
            this.zippedCheck.Size = new System.Drawing.Size(65, 17);
            this.zippedCheck.TabIndex = 6;
            this.zippedCheck.Text = "Zipped?";
            this.zippedCheck.UseVisualStyleBackColor = true;
            this.zippedCheck.CheckedChanged += new System.EventHandler(this.zippedCheck_CheckedChanged);
            // 
            // branchBox
            // 
            this.branchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchBox.Location = new System.Drawing.Point(62, 93);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(360, 20);
            this.branchBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Branch:";
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(12, 148);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.output.Size = new System.Drawing.Size(410, 96);
            this.output.TabIndex = 11;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 255);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branchBox);
            this.Controls.Add(this.zippedCheck);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.fromButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AutoZipBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.CheckBox zippedCheck;
        private System.Windows.Forms.TextBox branchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox output;
    }
}

