// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.ColorspaceGType))]
	public enum Colorspace {

		Rgb,
	}

	internal class ColorspaceGType {
		[DllImport ("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_colorspace_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_colorspace_get_type ());
			}
		}
	}
#endregion
}
