using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace unet
{
	public class PingExample
	{
		public static void Pinger(){
			string ipAddress = "10.74.5.200";
			Ping pingSender = new Ping ();
			PingOptions options = new PingOptions ();
			options.DontFragment = true;
			string data = "lenyaz_asterisk_pinger";
			byte[] buffer = Encoding.ASCII.GetBytes (data);
			int timeout = 120;
			PingReply reply = pingSender.Send (ipAddress, timeout, buffer, options);
			if (reply.Status == IPStatus.Success)
			{
				Console.WriteLine("ok");
				//Console.WriteLine ("Address: {0}", reply.Address.ToString ());
				//Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
				//Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
				//Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
				//Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
			}
			else {
				Console.WriteLine("error");
			}
		}
		
		
		public static void Main ()
		{ while (true) { Pinger(); Thread.Sleep(2000); } }
	}
}
