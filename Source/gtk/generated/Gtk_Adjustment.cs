// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Adjustment : GLib.InitiallyUnowned {

		public Adjustment (IntPtr raw) : base(raw) {}

		protected Adjustment() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_value(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_value(IntPtr raw, double value);

		[GLib.Property ("value")]
		public double Value {
			get  {
				double raw_ret = gtk_adjustment_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_value(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_lower(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_lower(IntPtr raw, double lower);

		[GLib.Property ("lower")]
		public double Lower {
			get  {
				double raw_ret = gtk_adjustment_get_lower(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_lower(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_upper(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_upper(IntPtr raw, double upper);

		[GLib.Property ("upper")]
		public double Upper {
			get  {
				double raw_ret = gtk_adjustment_get_upper(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_upper(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_step_increment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_step_increment(IntPtr raw, double step_increment);

		[GLib.Property ("step-increment")]
		public double StepIncrement {
			get  {
				double raw_ret = gtk_adjustment_get_step_increment(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_step_increment(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_page_increment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_page_increment(IntPtr raw, double page_increment);

		[GLib.Property ("page-increment")]
		public double PageIncrement {
			get  {
				double raw_ret = gtk_adjustment_get_page_increment(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_page_increment(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_page_size(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_set_page_size(IntPtr raw, double page_size);

		[GLib.Property ("page-size")]
		public double PageSize {
			get  {
				double raw_ret = gtk_adjustment_get_page_size(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_adjustment_set_page_size(Handle, value);
			}
		}

		[GLib.Signal("value-changed")]
		public event System.EventHandler ValueChanged {
			add {
				this.AddSignalHandler ("value-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("value-changed", value);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				Adjustment __obj = GLib.Object.GetObject (inst, false) as Adjustment;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Adjustment), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				unmanaged = (ChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ValueChangedNativeDelegate ValueChanged_cb_delegate;
		static ValueChangedNativeDelegate ValueChangedVMCallback {
			get {
				if (ValueChanged_cb_delegate == null)
					ValueChanged_cb_delegate = new ValueChangedNativeDelegate (ValueChanged_cb);
				return ValueChanged_cb_delegate;
			}
		}

		static void OverrideValueChanged (GLib.GType gtype)
		{
			OverrideValueChanged (gtype, ValueChangedVMCallback);
		}

		static void OverrideValueChanged (GLib.GType gtype, ValueChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("value_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueChangedNativeDelegate (IntPtr inst);

		static void ValueChanged_cb (IntPtr inst)
		{
			try {
				Adjustment __obj = GLib.Object.GetObject (inst, false) as Adjustment;
				__obj.OnValueChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Adjustment), ConnectionMethod="OverrideValueChanged")]
		protected virtual void OnValueChanged ()
		{
			InternalValueChanged ();
		}

		private void InternalValueChanged ()
		{
			ValueChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("value_changed"));
				unmanaged = (ValueChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ValueChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, null
							, "value_changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("value_changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // value_changed
							, "changed"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "value_changed"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_changed(IntPtr raw);

		[Obsolete]
		public void Change() {
			gtk_adjustment_changed(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_clamp_page(IntPtr raw, double lower, double upper);

		public void ClampPage(double lower, double upper) {
			gtk_adjustment_clamp_page(Handle, lower, upper);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_configure(IntPtr raw, double value, double lower, double upper, double step_increment, double page_increment, double page_size);

		public void Configure(double value, double lower, double upper, double step_increment, double page_increment, double page_size) {
			gtk_adjustment_configure(Handle, value, lower, upper, step_increment, page_increment, page_size);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_adjustment_get_minimum_increment(IntPtr raw);

		public double MinimumIncrement { 
			get {
				double raw_ret = gtk_adjustment_get_minimum_increment(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_adjustment_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_adjustment_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_adjustment_value_changed(IntPtr raw);

		[Obsolete]
		public void ChangeValue() {
			gtk_adjustment_value_changed(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}