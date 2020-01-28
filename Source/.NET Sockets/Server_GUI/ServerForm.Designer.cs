namespace Server_GUI
{
	partial class ServerForm
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
			this.BtnListen = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.TxtSend = new System.Windows.Forms.TextBox();
			this.BtnSend = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnListen
			// 
			this.BtnListen.Location = new System.Drawing.Point(12, 12);
			this.BtnListen.Name = "BtnListen";
			this.BtnListen.Size = new System.Drawing.Size(173, 23);
			this.BtnListen.TabIndex = 0;
			this.BtnListen.Text = "Listen";
			this.BtnListen.UseVisualStyleBackColor = true;
			this.BtnListen.Click += new System.EventHandler(this.BtnListen_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 41);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(173, 121);
			this.listBox1.TabIndex = 1;
			// 
			// TxtSend
			// 
			this.TxtSend.Location = new System.Drawing.Point(12, 168);
			this.TxtSend.Name = "TxtSend";
			this.TxtSend.Size = new System.Drawing.Size(117, 20);
			this.TxtSend.TabIndex = 2;
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(135, 166);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(50, 23);
			this.BtnSend.TabIndex = 0;
			this.BtnSend.Text = "Send";
			this.BtnSend.UseVisualStyleBackColor = true;
			this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 203);
			this.Controls.Add(this.TxtSend);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.BtnSend);
			this.Controls.Add(this.BtnListen);
			this.Name = "ServerForm";
			this.Text = "Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnListen;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox TxtSend;
		private System.Windows.Forms.Button BtnSend;
	}
}

