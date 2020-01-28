using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClientAsync
{
	public partial class ClientAsyncForm : Form
	{
		Client client;

		public ClientAsyncForm()
		{
			InitializeComponent();

			BtnDisconnect.Click += BtnDisconnect_Click;
			BtnSendImage.Click += BtnSendImage_Click;
			BtnSendText.Click += BtnSendText_Click;
			BtnConnect.Click += BtnConnect_Click;

			client = new Client();
			client.OnConnect += Client_OnConnect;
			client.OnSend += Client_OnSend;
			client.OnDisconnect += Client_OnDisconnect;
		}

		private void Client_OnDisconnect(Client sender)
		{
			MessageBox.Show("Disconnected!");
		}

		private void Client_OnSend(Client sender, int sent)
		{
			Invoke((MethodInvoker)delegate
			{
				LblDataSent.Text = $"Data Sent: {sent}";
			});
		}

		private void Client_OnConnect(Client sender, bool connected)
		{
			if (connected)
				MessageBox.Show("Connection accepted!");
		}

		private void BtnConnect_Click(object sender, EventArgs e)
		{
			if (!client.Connected)
				client.Connect("127.0.0.1", 8192);
		}

		private void BtnSendText_Click(object sender, EventArgs e)
		{
			SendText(TxtMsg.Text);
		}

		private void BtnSendImage_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog o = new OpenFileDialog())
			{
				o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				if(o.ShowDialog() == DialogResult.OK)
				{
					SendImage(o.FileName);
				}
			}
		}

		private void BtnDisconnect_Click(object sender, EventArgs e)
		{
			client.Disconnect();
		}

		void SendText(string text)
		{
			BinaryWriter bw = new BinaryWriter(new MemoryStream());

			bw.Write((int)Commands.String);
			bw.Write(text);
			bw.Close();

			byte[] data = ((MemoryStream)bw.BaseStream).ToArray();

			bw.BaseStream.Dispose();

			client.Send(data, 0, data.Length);

			data = null;
		}

		void SendImage(string path)
		{
			MemoryStream ms = new MemoryStream();

			BinaryWriter bw = new BinaryWriter(ms);

			byte[] b = File.ReadAllBytes(path);

			bw.Write((int)Commands.Image);

			bw.Write(b.Length);

			bw.Write(b);

			bw.Close();

			b = ms.ToArray();

			ms.Dispose();

			client.Send(b, 0, b.Length);
		}
	}
}
