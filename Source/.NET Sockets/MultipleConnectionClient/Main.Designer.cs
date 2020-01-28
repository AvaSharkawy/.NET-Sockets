namespace MultipleConnectionClient
{
	partial class Main
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
			this.BtnConnect = new System.Windows.Forms.Button();
			this.BtnSend = new System.Windows.Forms.Button();
			this.TxtMsg = new System.Windows.Forms.TextBox();
			this.BtnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnConnect
			// 
			this.BtnConnect.Location = new System.Drawing.Point(13, 12);
			this.BtnConnect.Name = "BtnConnect";
			this.BtnConnect.Size = new System.Drawing.Size(123, 23);
			this.BtnConnect.TabIndex = 0;
			this.BtnConnect.Text = "Connect";
			this.BtnConnect.UseVisualStyleBackColor = true;
			this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(13, 41);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(123, 23);
			this.BtnSend.TabIndex = 0;
			this.BtnSend.Text = "Send";
			this.BtnSend.UseVisualStyleBackColor = true;
			this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// TxtMsg
			// 
			this.TxtMsg.Location = new System.Drawing.Point(13, 71);
			this.TxtMsg.Name = "TxtMsg";
			this.TxtMsg.Size = new System.Drawing.Size(122, 20);
			this.TxtMsg.TabIndex = 1;
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(13, 97);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(122, 23);
			this.BtnClose.TabIndex = 2;
			this.BtnClose.Text = "Close";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(148, 138);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.TxtMsg);
			this.Controls.Add(this.BtnSend);
			this.Controls.Add(this.BtnConnect);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnConnect;
		private System.Windows.Forms.Button BtnSend;
		private System.Windows.Forms.TextBox TxtMsg;
		private System.Windows.Forms.Button BtnClose;
	}
}