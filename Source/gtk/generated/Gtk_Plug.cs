// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Plug : Gtk.Window {

		public Plug (IntPtr raw) : base(raw) {}

		protected Plug() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_plug_get_embedded(IntPtr raw);

		[GLib.Property ("embedded")]
		public bool IsEmbedded {
			get  {
				bool raw_ret = gtk_plug_get_embedded(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_plug_get_socket_window(IntPtr raw);

		[GLib.Property ("socket-window")]
		public Gdk.Window SocketWindow {
			get  {
				IntPtr raw_ret = gtk_plug_get_socket_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[GLib.Signal("embedded")]
		public event System.EventHandler Embedded {
			add {
				this.AddSignalHandler ("embedded", value);
			}
			remove {
				this.RemoveSignalHandler ("embedded", value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_plug_construct(IntPtr raw, UIntPtr socket_id);

		public void Construct(ulong socket_id) {
			gtk_plug_construct(Handle, new UIntPtr (socket_id));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_plug_construct_for_display(IntPtr raw, IntPtr display, UIntPtr socket_id);

		public void ConstructForDisplay(Gdk.Display display, ulong socket_id) {
			gtk_plug_construct_for_display(Handle, display == null ? IntPtr.Zero : display.Handle, new UIntPtr (socket_id));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gtk_plug_get_id(IntPtr raw);

		public ulong Id { 
			get {
				UIntPtr raw_ret = gtk_plug_get_id(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_plug_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_plug_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
