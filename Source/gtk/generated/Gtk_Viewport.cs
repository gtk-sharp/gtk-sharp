// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Viewport : Gtk.Bin, Gtk.IScrollable {

		public Viewport (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_new(IntPtr hadjustment, IntPtr vadjustment);

		public Viewport (Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Viewport)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (hadjustment != null) {
					names.Add ("hadjustment");
					vals.Add (new GLib.Value (hadjustment));
				}
				if (vadjustment != null) {
					names.Add ("vadjustment");
					vals.Add (new GLib.Value (vadjustment));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_viewport_new(hadjustment == null ? IntPtr.Zero : hadjustment.Handle, vadjustment == null ? IntPtr.Zero : vadjustment.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_viewport_get_shadow_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_viewport_set_shadow_type(IntPtr raw, int type);

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get  {
				int raw_ret = gtk_viewport_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set  {
				gtk_viewport_set_shadow_type(Handle, (int) value);
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

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_bin_window(IntPtr raw);

		public Gdk.Window BinWindow { 
			get {
				IntPtr raw_ret = gtk_viewport_get_bin_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_viewport_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_view_window(IntPtr raw);

		public Gdk.Window ViewWindow { 
			get {
				IntPtr raw_ret = gtk_viewport_get_view_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_scrollable_get_border(IntPtr raw, IntPtr border);

		public bool GetBorder(Gtk.Border border) {
			IntPtr native_border = GLib.Marshaller.StructureToPtrAlloc (border);
			bool raw_ret = gtk_scrollable_get_border(Handle, native_border);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_border);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_hadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hadjustment(IntPtr raw, IntPtr hadjustment);

		[GLib.Property ("hadjustment")]
		public Gtk.Adjustment Hadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_hadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_hadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_vadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vadjustment(IntPtr raw, IntPtr vadjustment);

		[GLib.Property ("vadjustment")]
		public Gtk.Adjustment Vadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_vadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_vadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_hscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("hscroll-policy")]
		public Gtk.ScrollablePolicy HscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_hscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_hscroll_policy(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_vscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("vscroll-policy")]
		public Gtk.ScrollablePolicy VscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_vscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_vscroll_policy(Handle, (int) value);
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
