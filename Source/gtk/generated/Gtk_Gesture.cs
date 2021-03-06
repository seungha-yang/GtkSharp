// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Gesture : Gtk.EventController {

		public Gesture (IntPtr raw) : base(raw) {}

		protected Gesture() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("n-points")]
		public uint NPoints {
			get {
				GLib.Value val = GetProperty ("n-points");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_window(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gesture_set_window(IntPtr raw, IntPtr window);

		[GLib.Property ("window")]
		public Gdk.Window Window {
			get  {
				IntPtr raw_ret = gtk_gesture_get_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
			set  {
				gtk_gesture_set_window(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("update")]
		public event Gtk.UpdateHandler Update {
			add {
				this.AddSignalHandler ("update", value, typeof (Gtk.UpdateArgs));
			}
			remove {
				this.RemoveSignalHandler ("update", value);
			}
		}

		[GLib.Signal("sequence-state-changed")]
		public event Gtk.SequenceStateChangedHandler SequenceStateChanged {
			add {
				this.AddSignalHandler ("sequence-state-changed", value, typeof (Gtk.SequenceStateChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("sequence-state-changed", value);
			}
		}

		[GLib.Signal("cancel")]
		public event Gtk.CancelHandler Cancel {
			add {
				this.AddSignalHandler ("cancel", value, typeof (Gtk.CancelArgs));
			}
			remove {
				this.RemoveSignalHandler ("cancel", value);
			}
		}

		[GLib.Signal("begin")]
		public event Gtk.BeginHandler Begin {
			add {
				this.AddSignalHandler ("begin", value, typeof (Gtk.BeginArgs));
			}
			remove {
				this.RemoveSignalHandler ("begin", value);
			}
		}

		[GLib.Signal("end")]
		public event Gtk.EndHandler End {
			add {
				this.AddSignalHandler ("end", value, typeof (Gtk.EndArgs));
			}
			remove {
				this.RemoveSignalHandler ("end", value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_get_bounding_box(IntPtr raw, IntPtr rect);

		public bool GetBoundingBox(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			bool raw_ret = gtk_gesture_get_bounding_box(Handle, native_rect);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rect);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_get_bounding_box_center(IntPtr raw, out double x, out double y);

		public bool GetBoundingBoxCenter(out double x, out double y) {
			bool raw_ret = gtk_gesture_get_bounding_box_center(Handle, out x, out y);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_device(IntPtr raw);

		public Gdk.Device Device { 
			get {
				IntPtr raw_ret = gtk_gesture_get_device(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_last_event(IntPtr raw, IntPtr sequence);

		public Gdk.Event GetLastEvent(Gdk.EventSequence sequence) {
			IntPtr raw_ret = gtk_gesture_get_last_event(Handle, sequence == null ? IntPtr.Zero : sequence.Handle);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_last_updated_sequence(IntPtr raw);

		public Gdk.EventSequence LastUpdatedSequence { 
			get {
				IntPtr raw_ret = gtk_gesture_get_last_updated_sequence(Handle);
				Gdk.EventSequence ret = raw_ret == IntPtr.Zero ? null : (Gdk.EventSequence) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.EventSequence), false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_get_point(IntPtr raw, IntPtr sequence, out double x, out double y);

		public bool GetPoint(Gdk.EventSequence sequence, out double x, out double y) {
			bool raw_ret = gtk_gesture_get_point(Handle, sequence == null ? IntPtr.Zero : sequence.Handle, out x, out y);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_gesture_get_sequence_state(IntPtr raw, IntPtr sequence);

		public Gtk.EventSequenceState GetSequenceState(Gdk.EventSequence sequence) {
			int raw_ret = gtk_gesture_get_sequence_state(Handle, sequence == null ? IntPtr.Zero : sequence.Handle);
			Gtk.EventSequenceState ret = (Gtk.EventSequenceState) raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_sequences(IntPtr raw);

		public GLib.List Sequences { 
			get {
				IntPtr raw_ret = gtk_gesture_get_sequences(Handle);
				GLib.List ret = new GLib.List(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gesture_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gesture_group(IntPtr raw, IntPtr gesture);

		public void Group(Gtk.Gesture gesture) {
			gtk_gesture_group(Handle, gesture == null ? IntPtr.Zero : gesture.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_handles_sequence(IntPtr raw, IntPtr sequence);

		public bool HandlesSequence(Gdk.EventSequence sequence) {
			bool raw_ret = gtk_gesture_handles_sequence(Handle, sequence == null ? IntPtr.Zero : sequence.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = gtk_gesture_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_is_grouped_with(IntPtr raw, IntPtr other);

		public bool IsGroupedWith(Gtk.Gesture other) {
			bool raw_ret = gtk_gesture_is_grouped_with(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_is_recognized(IntPtr raw);

		public bool IsRecognized { 
			get {
				bool raw_ret = gtk_gesture_is_recognized(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_set_sequence_state(IntPtr raw, IntPtr sequence, int state);

		public bool SetSequenceState(Gdk.EventSequence sequence, Gtk.EventSequenceState state) {
			bool raw_ret = gtk_gesture_set_sequence_state(Handle, sequence == null ? IntPtr.Zero : sequence.Handle, (int) state);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_set_state(IntPtr raw, int state);

		public bool SetState(Gtk.EventSequenceState state) {
			bool raw_ret = gtk_gesture_set_state(Handle, (int) state);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gesture_ungroup(IntPtr raw);

		public void Ungroup() {
			gtk_gesture_ungroup(Handle);
		}

#endregion
	}
}
