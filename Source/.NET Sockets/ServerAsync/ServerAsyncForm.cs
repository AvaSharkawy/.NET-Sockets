using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ServerAsync
{
	public partial class ServerAsyncForm : Form
	{
		Listener listener;

		Client client;

		public ServerAsyncForm()
		{
			InitializeComponent();

			BtnListen.Click += BtnListen_Click;
			BtnClose.Click += BtnClose_Click;

			FormClosing += ServerAsyncForm_FormClosing;
		}

		private void ServerAsyncForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (client != null)
				client.Close();

			if (listener != null && listener.Running)
				listener.Stop();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			if (client != null)
			{
				client.Close();
				client = null;
			}

			listener.Stop();

			LblStatus.Text = "Connected: NULL";

			LsItems.Items.Clear();

			PicBox.Image = null;
		}

		private void BtnListen_Click(object sender, EventArgs e)
		{
			listener = new Listener();
			
			listener.Accepted += Listener_Accepted;

			listener.Start(8192);

		}

		private void Listener_Accepted(Socket e)
		{
			if(client != null)
			{
				e.Close();
				return;
			}

			client = new Client(e);
			client.DataReceived += Client_DataReceived;
			client.Disconnected += Client_Disconnected;
			client.ReceiveAsync();

			Invoke((MethodInvoker)delegate
			{
				LblStatus.Text = $"Connected: {client.EndPoint.ToString()}";
			});
		}

		private void Client_Disconnected(Client sender)
		{
			client.Close();

			client = null;

			Invoke((MethodInvoker)delegate
			{
				LblStatus.Text = "Connected: NULL";

				DialogResult res = MessageBox.Show("Client disconnected\nClear data?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if(res == DialogResult.Yes)
				{
					LsItems.Items.Clear();

					PicBox.Image = null;
				}
			});
		}

		private void Client_DataReceived(Client sernder, ReceiveBuffer e)
		{
			BinaryReader r = new BinaryReader(e.BufStream);

			Commands header = (Commands)r.ReadInt32();

			switch(header)
			{
				case Commands.String:
				{
					string s = r.ReadString();

					Invoke((MethodInvoker)delegate
					{
						LsItems.Items.Add(s);
					});
				}
				break;

				case Commands.Image:
				{
					int imageByteLen = r.ReadInt32();

					byte[] iBytes = r.ReadBytes(imageByteLen);

					Invoke((MethodInvoker)delegate
					{
						PicBox.Image = Image.FromStream(new MemoryStream(iBytes));
					});

					iBytes = null;
				}
				break;
			}
		}
	}
}
