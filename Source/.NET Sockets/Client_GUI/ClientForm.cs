using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client_GUI
{
	public partial class ClientForm : Form
	{
		Socket sock;

		public ClientForm()
		{
			InitializeComponent();
			sock = socket();
			FormClosing += (ss, ee) =>
			{
				sock.Close();
			};
		}

		Socket socket()
		{
			return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}

		private void BtnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				sock.Connect(new IPEndPoint(IPAddress.Parse(TxtIP.Text), 3));

				new Thread(() =>
				{
					read();
				}).Start();
			}
			catch
			{
				MessageBox.Show("Connection failed!");
			}
		}

		void read()
		{
			while (true)
			{
				try
				{
					var buffer = new byte[255];

					int rec = sock.Receive(buffer, 0, buffer.Length, 0);

					if (rec <= 0)
						throw new SocketException();

					Array.Resize(ref buffer, rec);

					Invoke((MethodInvoker)delegate
					{
						listBox1.Items.Add(Encoding.Default.GetString(buffer));
					});
				}
				catch
				{
					MessageBox.Show("Disconnection!");
					sock.Close();
					break;
				}
			}
			Application.Exit();
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			var data = Encoding.Default.GetBytes(TxtSend.Text);

			sock.Send(data, 0, data.Length, 0);


		}
	}
}
