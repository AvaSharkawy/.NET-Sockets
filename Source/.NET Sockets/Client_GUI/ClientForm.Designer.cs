namespace Client_GUI
{
	partial class ClientForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.BtnSend = new System.Windows.Forms.Button();
			this.TxtSend = new System.Windows.Forms.TextBox();
			this.BtnConnect = new System.Windows.Forms.Button();
			this.TxtIP = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 41);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(242, 95);
			this.listBox1.TabIndex = 7;
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(179, 142);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(75, 23);
			this.BtnSend.TabIndex = 5;
			this.BtnSend.Text = "Send";
			this.BtnSend.UseVisualStyleBackColor = true;
			this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// TxtSend
			// 
			this.TxtSend.Location = new System.Drawing.Point(12, 144);
			this.TxtSend.Name = "TxtSend";
			this.TxtSend.Size = new System.Drawing.Size(164, 20);
			this.TxtSend.TabIndex = 3;
			// 
			// BtnConnect
			// 
			this.BtnConnect.Location = new System.Drawing.Point(179, 8);
			this.BtnConnect.Name = "BtnConnect";
			this.BtnConnect.Size = new System.Drawing.Size(75, 23);
			this.BtnConnect.TabIndex = 6;
			this.BtnConnect.Text = "Connect";
			this.BtnConnect.UseVisualStyleBackColor = true;
			this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// TxtIP
			// 
			this.TxtIP.Location = new System.Drawing.Point(12, 10);
			this.TxtIP.Name = "TxtIP";
			this.TxtIP.Size = new System.Drawing.Size(164, 20);
			this.TxtIP.TabIndex = 4;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 175);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.BtnSend);
			this.Controls.Add(this.TxtSend);
			this.Controls.Add(this.BtnConnect);
			this.Controls.Add(this.TxtIP);
			this.Name = "ClientForm";
			this.Text = "ClientForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button BtnSend;
		private System.Windows.Forms.TextBox TxtSend;
		private System.Windows.Forms.Button BtnConnect;
		private System.Windows.Forms.TextBox TxtIP;
	}
}