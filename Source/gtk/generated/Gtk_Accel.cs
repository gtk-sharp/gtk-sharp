// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Accel {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_accel_groups_activate(IntPtr objekt, uint accel_key, int accel_mods);

		public static bool GroupsActivate(GLib.Object objekt, uint accel_key, Gdk.ModifierType accel_mods) {
			bool raw_ret = gtk_accel_groups_activate(objekt == null ? IntPtr.Zero : objekt.Handle, accel_key, (int) accel_mods);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
