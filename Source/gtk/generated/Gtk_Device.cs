// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Device {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_device_grab_add(IntPtr widget, IntPtr device, bool block_others);

		public static void GrabAdd(Gtk.Widget widget, Gdk.Device device, bool block_others) {
			gtk_device_grab_add(widget == null ? IntPtr.Zero : widget.Handle, device == null ? IntPtr.Zero : device.Handle, block_others);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_device_grab_remove(IntPtr widget, IntPtr device);

		public static void GrabRemove(Gtk.Widget widget, Gdk.Device device) {
			gtk_device_grab_remove(widget == null ? IntPtr.Zero : widget.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

#endregion
	}
}
