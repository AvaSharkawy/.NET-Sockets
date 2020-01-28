using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			var sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

			try
			{
				sck.Connect(endPoint);
			}
			catch
			{
				Console.WriteLine("Unable to connect to remote end point!");
				Main(args);
			}

			Console.Write("Enter Text: ");

			string text = Console.ReadLine();

			byte[] data = Encoding.Default.GetBytes(text);

			sck.Send(data, 0, data.Length, 0);

			byte[] buffer = new byte[255];

			int rec = sck.Receive(buffer, 0, buffer.Length, 0);

			Array.Resize(ref buffer, rec);

			Console.WriteLine($"Received: {Encoding.Default.GetString(buffer)}");

			sck.Close();

			Console.Read();
		}
	}
}
