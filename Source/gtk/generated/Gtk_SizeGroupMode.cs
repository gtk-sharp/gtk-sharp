// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.SizeGroupModeGType))]
	public enum SizeGroupMode {

		None,
		Horizontal,
		Vertical,
		Both,
	}

	internal class SizeGroupModeGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_size_group_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_size_group_mode_get_type ());
			}
		}
	}
#endregion
}
