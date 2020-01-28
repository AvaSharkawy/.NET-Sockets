using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerAsync
{
	class Listener
	{
		public delegate void SocketAcceptedEventHandler(Socket e);

		public event SocketAcceptedEventHandler Accepted;

		Socket listener;

		public int Port;

		public bool Running { get; private set; }

		public Listener() { Port = 0; }

		public void Start(int port)
		{
			if (Running)
				return;

			listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			listener.Bind(new IPEndPoint(IPAddress.Any, port));

			listener.Listen(0);

			listener.BeginAccept(acceptedCallback, null);
			Running = true;
		}

		public void Stop()
		{
			if (!Running)
				return;

			listener.Close();

			Running = false;
		}

		void acceptedCallback(IAsyncResult ar)
		{
			try
			{
				Socket s = listener.EndAccept(ar);

				if (Accepted != null)
					Accepted(s);
			}
			catch
			{

			}

			if (Running)
			{
				try
				{
					listener.BeginAccept(acceptedCallback, null);
				}
				catch { }
			}
		}
	}
}
