using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			var sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			sck.Bind(new IPEndPoint(0, 1234));

			sck.Listen(0);

			var acc = sck.Accept();

			var buffer = Encoding.Default.GetBytes("Welcome, Client!");
			acc.Send(buffer, 0, buffer.Length, 0);

			buffer = new byte[255];

			int rec = acc.Receive(buffer, 0, buffer.Length, 0);

			Array.Resize(ref buffer, rec);

			Console.WriteLine($"Received: {Encoding.Default.GetString(buffer)}");

			sck.Close();

			acc.Close();
			
			Console.Read();
		}
	}
}
