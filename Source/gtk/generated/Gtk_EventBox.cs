// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class EventBox : Gtk.Bin {

		public EventBox (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_event_box_new();

		public EventBox () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EventBox)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_event_box_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_event_box_get_visible_window(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_event_box_set_visible_window(IntPtr raw, bool visible_window);

		[GLib.Property ("visible-window")]
		public bool VisibleWindow {
			get  {
				bool raw_ret = gtk_event_box_get_visible_window(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_event_box_set_visible_window(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_event_box_get_above_child(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_event_box_set_above_child(IntPtr raw, bool above_child);

		[GLib.Property ("above-child")]
		public bool AboveChild {
			get  {
				bool raw_ret = gtk_event_box_get_above_child(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_event_box_set_above_child(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
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
		static extern IntPtr gtk_event_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_event_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Bin.abi_info.Fields
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
