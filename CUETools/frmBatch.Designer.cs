namespace JDP
{
	partial class frmBatch
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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(7, 6);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.progressBar2.MinimumSize = new System.Drawing.Size(953, 38);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1320, 38);
            this.progressBar2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Sarasa Term SC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(7, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.MaxLength = 0;
            this.textBox1.MinimumSize = new System.Drawing.Size(1295, 381);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1315, 410);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // txtInputFile
            // 
            this.txtInputFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputFile.Location = new System.Drawing.Point(11, 60);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(1320, 26);
            this.txtInputFile.TabIndex = 3;
            this.txtInputFile.TabStop = false;
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutputFile.Location = new System.Drawing.Point(11, 106);
            this.txtOutputFile.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(1320, 26);
            this.txtOutputFile.TabIndex = 4;
            this.txtOutputFile.TabStop = false;
            this.txtOutputFile.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOutputFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInputFile, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1342, 564);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // frmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1406, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Sarasa UI SC", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1026, 63);
            this.Name = "frmBatch";
            this.Padding = new System.Windows.Forms.Padding(22, 19, 22, 19);
            this.Text = "Working...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBatch_FormClosing);
            this.Load += new System.EventHandler(this.frmBatch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtInputFile;
		private System.Windows.Forms.TextBox txtOutputFile;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}