using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server_GUI
{
	public partial class ServerForm : Form
	{
		Socket sock;

		Socket acc;

		public ServerForm()
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

		private void BtnListen_Click(object sender, EventArgs e)
		{
			sock.Bind(new IPEndPoint(0, 3));

			sock.Listen(0);

			new Thread(delegate()
			{
				acc = sock.Accept();
				MessageBox.Show("Connected accepted!");
				sock.Close();

				while (true)
				{
					try
					{
						var buffer = new byte[255];

						var rec = acc.Receive(buffer, 0, buffer.Length, 0);

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
			}).Start();
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			var data = Encoding.Default.GetBytes(TxtSend.Text);

			acc.Send(data, 0, data.Length, 0);
		}
	}
}
