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

namespace MultipleConnectionServer
{
	public partial class Main : Form
	{
		Listener listener;
		public Main()
		{
			InitializeComponent();
			listener = new Listener(8);

			listener.SocketAccepted += Listener_SocketAccepted;
			Load += Main_Load;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			listener.Start();
		}

		private void Listener_SocketAccepted(Socket e)
		{
			Client client = new Client(e);

			client.Received += Client_Received;
			client.Disconnected += Client_Disconnected;

			Invoke((MethodInvoker)delegate
			{
				ListViewItem i = new ListViewItem();
				i.Text = client.EndPoint.ToString();
				i.SubItems.Add(client.ID);
				i.SubItems.Add("XX");
				i.SubItems.Add("XX");
				i.Tag = client;

				lvClients.Items.Add(i);
			});
		}

		private void Client_Disconnected(Client sender)
		{
			Invoke((MethodInvoker)delegate
			{
				for(int i = 0; i < lvClients.Items.Count; i++)
				{
					var client = lvClients.Items[i].Tag as Client;

					if(client.ID == sender.ID)
					{
						lvClients.Items.RemoveAt(i);
						break;
					}
				}
			});
		}

		private void Client_Received(Client sender, byte[] data)
		{
			Invoke((MethodInvoker)delegate
			{
				for (int i = 0; i < lvClients.Items.Count; i++)
				{
					var client = lvClients.Items[i].Tag as Client;

					if(client.ID == sender.ID)
					{
						lvClients.Items[i].SubItems[2].Text = Encoding.Default.GetString(data);
						lvClients.Items[i].SubItems[3].Text = DateTime.Now.ToString();
						break;
					}
				}
			});
		}
	}
}
