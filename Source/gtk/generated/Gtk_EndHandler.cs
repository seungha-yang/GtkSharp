// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void EndHandler(object o, EndArgs args);

	public class EndArgs : GLib.SignalArgs {
		public Gdk.EventSequence Sequence{
			get {
				return (Gdk.EventSequence) Args [0];
			}
		}

	}
}
