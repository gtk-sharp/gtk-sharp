// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.PrintErrorGType))]
	public enum PrintError {

		General,
		InternalError,
		Nomem,
		InvalidFile,
	}

	internal class PrintErrorGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_print_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_print_error_get_type ());
			}
		}
	}
#endregion
}