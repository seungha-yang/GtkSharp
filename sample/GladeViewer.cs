// GladeViewer.cs - Silly tests for LibGlade in C#
//
// Author: Ricardo Fernández Pascual <ric@users.sourceforge.net>
//
// (c) 2002 Ricardo Fernández Pascual

namespace GladeSamples {
	using System;
	using System.Runtime.InteropServices;

	using Gtk;
	using Gnome;
	using Glade;

	public class GladeDemo {

		public static void Main (string[] args)
		{
			if (args.Length < 2) {
				Console.WriteLine ("Use: mono ./glade-viewer.exe \"fname\" \"root\"");
				return;
			}

			Program viewer = new Program ("GladeViewer", "0.1", Modules.UI, args);

			string fname = args [0];
			string root = args [1];
			
			Glade.XML gxml = new Glade.XML (fname, root, null);
			Widget wid = gxml [root];
			wid.Show ();
			
			Console.WriteLine ("The filename: {0}", gxml.Filename);
			Console.WriteLine ("A relative filename: {0}", gxml.RelativeFile ("image.png"));

			Console.WriteLine ("The name of the root widget: {0}", Glade.XML.GetWidgetName (wid));
			Console.WriteLine ("BTW, it's {0} that it was created using from a Glade.XML object",
					   Glade.XML.GetWidgetTree (wid) != null);

			Console.WriteLine ("\nList of created widgets:");
			GLib.List l = gxml.GetWidgetPrefix ("");
			foreach (Widget w in l) {
				Console.WriteLine ("{0} {1}", 
						   w.GetType (),
						   Glade.XML.GetWidgetName (w));
			}
			
			viewer.Run ();
		}
		
	}
}
