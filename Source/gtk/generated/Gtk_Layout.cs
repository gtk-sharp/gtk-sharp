// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Layout : Gtk.Container, Gtk.IScrollable {

		public Layout (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_layout_new(IntPtr hadjustment, IntPtr vadjustment);

		public Layout (Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Layout)) {
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
			Raw = gtk_layout_new(hadjustment == null ? IntPtr.Zero : hadjustment.Handle, vadjustment == null ? IntPtr.Zero : vadjustment.Handle);
		}

		[GLib.Property ("width")]
		public uint Width {
			get {
				GLib.Value val = GetProperty ("width");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public uint Height {
			get {
				GLib.Value val = GetProperty ("height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("height", val);
				val.Dispose ();
			}
		}

		public class LayoutChild : Gtk.Container.ContainerChild {
			protected internal LayoutChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("x")]
			public int X {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "x");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "x", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("y")]
			public int Y {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "y");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "y", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new LayoutChild (this, child);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Container.class_abi.Fields
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
		static extern IntPtr gtk_layout_get_bin_window(IntPtr raw);

		public Gdk.Window BinWindow { 
			get {
				IntPtr raw_ret = gtk_layout_get_bin_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_layout_get_size(IntPtr raw, out uint width, out uint height);

		public void GetSize(out uint width, out uint height) {
			gtk_layout_get_size(Handle, out width, out height);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_layout_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_layout_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_layout_move(IntPtr raw, IntPtr child_widget, int x, int y);

		public void Move(Gtk.Widget child_widget, int x, int y) {
			gtk_layout_move(Handle, child_widget == null ? IntPtr.Zero : child_widget.Handle, x, y);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_layout_put(IntPtr raw, IntPtr child_widget, int x, int y);

		public void Put(Gtk.Widget child_widget, int x, int y) {
			gtk_layout_put(Handle, child_widget == null ? IntPtr.Zero : child_widget.Handle, x, y);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_layout_set_size(IntPtr raw, uint width, uint height);

		public void SetSize(uint width, uint height) {
			gtk_layout_set_size(Handle, width, height);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_scrollable_get_border(IntPtr raw, IntPtr border);

		public bool GetBorder(Gtk.Border border) {
			IntPtr native_border = GLib.Marshaller.StructureToPtrAlloc (border);
			bool raw_ret = gtk_scrollable_get_border(Handle, native_border);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_border);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_hadjustment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
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

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_vadjustment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
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

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_hscroll_policy(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
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

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_vscroll_policy(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
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
							, Gtk.Container.abi_info.Fields
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
