// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.PropModeGType))]
	public enum PropMode {

		Replace,
		Prepend,
		Append,
	}

	internal class PropModeGType {
		[DllImport ("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_prop_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_prop_mode_get_type ());
			}
		}
	}
#endregion
}
