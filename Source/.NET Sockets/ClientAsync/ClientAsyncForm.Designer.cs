namespace ClientAsync
{
	partial class ClientAsyncForm
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
			this.BtnSendText = new System.Windows.Forms.Button();
			this.BtnSendImage = new System.Windows.Forms.Button();
			this.BtnDisconnect = new System.Windows.Forms.Button();
			this.TxtMsg = new System.Windows.Forms.TextBox();
			this.LblDataSent = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnConnect
			// 
			this.BtnConnect.Location = new System.Drawing.Point(13, 21);
			this.BtnConnect.Name = "BtnConnect";
			this.BtnConnect.Size = new System.Drawing.Size(384, 30);
			this.BtnConnect.TabIndex = 0;
			this.BtnConnect.Text = "Connect";
			this.BtnConnect.UseVisualStyleBackColor = true;
			// 
			// BtnSendText
			// 
			this.BtnSendText.Location = new System.Drawing.Point(13, 57);
			this.BtnSendText.Name = "BtnSendText";
			this.BtnSendText.Size = new System.Drawing.Size(139, 30);
			this.BtnSendText.TabIndex = 0;
			this.BtnSendText.Text = "Send Text";
			this.BtnSendText.UseVisualStyleBackColor = true;
			// 
			// BtnSendImage
			// 
			this.BtnSendImage.Location = new System.Drawing.Point(13, 93);
			this.BtnSendImage.Name = "BtnSendImage";
			this.BtnSendImage.Size = new System.Drawing.Size(384, 30);
			this.BtnSendImage.TabIndex = 0;
			this.BtnSendImage.Text = "Send Image";
			this.BtnSendImage.UseVisualStyleBackColor = true;
			// 
			// BtnDisconnect
			// 
			this.BtnDisconnect.Location = new System.Drawing.Point(13, 129);
			this.BtnDisconnect.Name = "BtnDisconnect";
			this.BtnDisconnect.Size = new System.Drawing.Size(383, 30);
			this.BtnDisconnect.TabIndex = 0;
			this.BtnDisconnect.Text = "Disconnect";
			this.BtnDisconnect.UseVisualStyleBackColor = true;
			// 
			// TxtMsg
			// 
			this.TxtMsg.Font = new System.Drawing.Font("Tahoma", 14F);
			this.TxtMsg.Location = new System.Drawing.Point(159, 57);
			this.TxtMsg.Name = "TxtMsg";
			this.TxtMsg.Size = new System.Drawing.Size(237, 30);
			this.TxtMsg.TabIndex = 1;
			// 
			// LblDataSent
			// 
			this.LblDataSent.AutoSize = true;
			this.LblDataSent.Font = new System.Drawing.Font("Tahoma", 12F);
			this.LblDataSent.Location = new System.Drawing.Point(12, 162);
			this.LblDataSent.Name = "LblDataSent";
			this.LblDataSent.Size = new System.Drawing.Size(97, 19);
			this.LblDataSent.TabIndex = 2;
			this.LblDataSent.Text = "Data Sent: 0";
			// 
			// ClientAsyncForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 191);
			this.Controls.Add(this.LblDataSent);
			this.Controls.Add(this.TxtMsg);
			this.Controls.Add(this.BtnDisconnect);
			this.Controls.Add(this.BtnSendImage);
			this.Controls.Add(this.BtnSendText);
			this.Controls.Add(this.BtnConnect);
			this.Name = "ClientAsyncForm";
			this.Text = "ClientAsyncForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnConnect;
		private System.Windows.Forms.Button BtnSendText;
		private System.Windows.Forms.Button BtnSendImage;
		private System.Windows.Forms.Button BtnDisconnect;
		private System.Windows.Forms.TextBox TxtMsg;
		private System.Windows.Forms.Label LblDataSent;
	}
}

