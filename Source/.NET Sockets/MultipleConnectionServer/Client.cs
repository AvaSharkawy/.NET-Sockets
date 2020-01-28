﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace MultipleConnectionServer
{
	class Client
	{
		public string ID { get; private set; }

		public IPEndPoint EndPoint { get; private set; }

		Socket sck;

		public Client(Socket accepted)
		{
			sck = accepted;
			ID = Guid.NewGuid().ToString();
			EndPoint = (IPEndPoint)sck.RemoteEndPoint;
			sck.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
		}

		void callback (IAsyncResult ar)
		{
			try
			{
				sck.EndReceive(ar);

				byte[] buf = new byte[8192];

				int rec = sck.Receive(buf, 0, buf.Length, 0);

				if(rec < buf.Length)
				{
					Array.Resize(ref buf, rec);
				}

				if (Received != null)
					Received(this, buf);

				sck.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Close();

				if (Disconnected != null)
					Disconnected(this);
			}
		}

		public void Close()
		{
			sck.Close();

			sck.Dispose();
		}

		public delegate void ClientReceivedHandler(Client sender, byte[] data);

		public delegate void ClientDisconnectedHandler(Client sender);

		public event ClientReceivedHandler Received;

		public event ClientDisconnectedHandler Disconnected;
	}
}
