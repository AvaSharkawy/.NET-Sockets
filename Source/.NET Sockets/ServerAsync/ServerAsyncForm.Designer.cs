namespace ServerAsync
{
	partial class ServerAsyncForm
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
			this.PicBox = new System.Windows.Forms.PictureBox();
			this.BtnListen = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.LblStatus = new System.Windows.Forms.Label();
			this.LsItems = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// PicBox
			// 
			this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PicBox.Location = new System.Drawing.Point(12, 12);
			this.PicBox.Name = "PicBox";
			this.PicBox.Size = new System.Drawing.Size(270, 262);
			this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBox.TabIndex = 0;
			this.PicBox.TabStop = false;
			// 
			// BtnListen
			// 
			this.BtnListen.Location = new System.Drawing.Point(12, 281);
			this.BtnListen.Name = "BtnListen";
			this.BtnListen.Size = new System.Drawing.Size(128, 33);
			this.BtnListen.TabIndex = 1;
			this.BtnListen.Text = "Listen";
			this.BtnListen.UseVisualStyleBackColor = true;
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(154, 281);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(128, 33);
			this.BtnClose.TabIndex = 1;
			this.BtnClose.Text = "Close";
			this.BtnClose.UseVisualStyleBackColor = true;
			// 
			// LblStatus
			// 
			this.LblStatus.AutoSize = true;
			this.LblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblStatus.Location = new System.Drawing.Point(288, 12);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(132, 19);
			this.LblStatus.TabIndex = 2;
			this.LblStatus.Text = "Connected: NULL";
			// 
			// LsItems
			// 
			this.LsItems.FormattingEnabled = true;
			this.LsItems.Location = new System.Drawing.Point(292, 37);
			this.LsItems.Name = "LsItems";
			this.LsItems.Size = new System.Drawing.Size(289, 277);
			this.LsItems.TabIndex = 4;
			// 
			// ServerAsyncForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 331);
			this.Controls.Add(this.LsItems);
			this.Controls.Add(this.LblStatus);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.BtnListen);
			this.Controls.Add(this.PicBox);
			this.Name = "ServerAsyncForm";
			this.Text = "Server Async";
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PicBox;
		private System.Windows.Forms.Button BtnListen;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.Label LblStatus;
		private System.Windows.Forms.ListBox LsItems;
	}
}

