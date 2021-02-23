using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace unet
{
	public class PingExample
	{
		public static void Pinger(){
			const int sleepTime = 2000;
			string ipAddress = "10.74.5.200";
			Ping pingSender = new Ping ();
			PingOptions options = new PingOptions ();
			options.DontFragment = true;
			string data = "lenyaz_asterisk_pinger";
			byte[] buffer = Encoding.ASCII.GetBytes (data);
			int timeout = 120;
			PingReply reply = pingSender.Send (ipAddress, timeout, buffer, options);
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			NotifyIcon notifyIcon1 = new NotifyIcon();
			ContextMenu contextMenu1 = new ContextMenu();
			MenuItem menuItem0 = new MenuItem();
			contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem0 });
			menuItem0.Index = 0;
			menuItem0.Text = "close";
			menuItem0.Click += new EventHandler(menuItem1_Click);
			notifyIcon1.Visible = true;
			//Application.Run();
			
			//notifyIcon1.Icon = null;
			
			Icon okIcon = new Icon("ok.ico");
			
			if (reply.Status == IPStatus.Success)
			{
				Console.WriteLine("ok");
				//notifyIcon1.Icon = new Icon("ok.ico"); //TODO: 
				notifyIcon1.Icon = okIcon; //TODO: 
				//notifyIcon1.Icon = null;
				//Console.WriteLine ("Address: {0}", reply.Address.ToString ());
				//Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
				//Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
				//Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
				//Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
			}
			else {
				Console.WriteLine("error");
				notifyIcon1.Icon = new Icon("error.ico");
			}
			notifyIcon1.Dispose();
			Thread.Sleep(sleepTime);
		}
		
		
		
		public static void Main ()
		{ while (true) { Pinger();  ;} }
		
		private static void menuItem1_Click(object Sender, EventArgs e){ Application.Exit(); }
	}
}
