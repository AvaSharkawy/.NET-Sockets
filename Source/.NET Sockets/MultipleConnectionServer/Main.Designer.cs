namespace MultipleConnectionServer
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
			this.lvClients = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvClients
			// 
			this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvClients.HideSelection = false;
			this.lvClients.Location = new System.Drawing.Point(12, 12);
			this.lvClients.Name = "lvClients";
			this.lvClients.Size = new System.Drawing.Size(776, 426);
			this.lvClients.TabIndex = 0;
			this.lvClients.UseCompatibleStateImageBehavior = false;
			this.lvClients.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "End Point";
			this.columnHeader1.Width = 147;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ID";
			this.columnHeader2.Width = 160;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last Msg";
			this.columnHeader3.Width = 272;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Last Rec Date";
			this.columnHeader4.Width = 185;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lvClients);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvClients;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}