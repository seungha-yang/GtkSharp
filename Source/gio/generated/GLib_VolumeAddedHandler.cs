// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void VolumeAddedHandler(object o, VolumeAddedArgs args);

	public class VolumeAddedArgs : GLib.SignalArgs {
		public GLib.IVolume Volume{
			get {
				return GLib.VolumeAdapter.GetObject (Args [0] as GLib.Object);
			}
		}

	}
}
