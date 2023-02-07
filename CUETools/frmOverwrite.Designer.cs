namespace JDP
{
	partial class frmOverwrite
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
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.labelAlreadyExist = new System.Windows.Forms.Label();
            this.textFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(1278, 512);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(163, 44);
            this.buttonNo.TabIndex = 0;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.Location = new System.Drawing.Point(1103, 512);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(163, 44);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(20, 522);
            this.checkBoxRemember.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(267, 30);
            this.checkBoxRemember.TabIndex = 3;
            this.checkBoxRemember.Text = "Remember my choice";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // labelAlreadyExist
            // 
            this.labelAlreadyExist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlreadyExist.AutoSize = true;
            this.labelAlreadyExist.Location = new System.Drawing.Point(462, 521);
            this.labelAlreadyExist.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAlreadyExist.Name = "labelAlreadyExist";
            this.labelAlreadyExist.Size = new System.Drawing.Size(448, 26);
            this.labelAlreadyExist.TabIndex = 2;
            this.labelAlreadyExist.Text = "Some of the files already exist. Overwrite?";
            // 
            // textFiles
            // 
            this.textFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFiles.Font = new System.Drawing.Font("Sarasa UI SC", 8.25F);
            this.textFiles.Location = new System.Drawing.Point(20, 17);
            this.textFiles.Margin = new System.Windows.Forms.Padding(0);
            this.textFiles.Multiline = true;
            this.textFiles.Name = "textFiles";
            this.textFiles.ReadOnly = true;
            this.textFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFiles.Size = new System.Drawing.Size(1417, 485);
            this.textFiles.TabIndex = 4;
            this.textFiles.TabStop = false;
            // 
            // frmOverwrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 579);
            this.Controls.Add(this.textFiles);
            this.Controls.Add(this.labelAlreadyExist);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Font = new System.Drawing.Font("Sarasa UI SC", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOverwrite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Overwrite?";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNo;
		private System.Windows.Forms.Button buttonYes;
		private System.Windows.Forms.Label labelAlreadyExist;
		internal System.Windows.Forms.TextBox textFiles;
		internal System.Windows.Forms.CheckBox checkBoxRemember;
	}
}