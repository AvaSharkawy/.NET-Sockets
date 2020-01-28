using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MultipleConnectionClient
{
	public partial class Main : Form
	{
		Socket sck;

		public Main()
		{
			InitializeComponent();
			sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}

		private void BtnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				sck.Connect("127.0.0.1", 8);
				MessageBox.Show("Connected!");
			}
			catch
			{

			}
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			int s = sck.Send(Encoding.Default.GetBytes(TxtMsg.Text));

			if (s > 0)
				MessageBox.Show("Data sent!");

		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			sck.Close();
			sck.Dispose();
			Close();
		}
	}
}
