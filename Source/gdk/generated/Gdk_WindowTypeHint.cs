// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.WindowTypeHintGType))]
	public enum WindowTypeHint {

		Normal,
		Dialog,
		Menu,
		Toolbar,
		Splashscreen,
		Utility,
		Dock,
		Desktop,
		DropdownMenu,
		PopupMenu,
		Tooltip,
		Notification,
		Combo,
		Dnd,
	}

	internal class WindowTypeHintGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_window_type_hint_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_window_type_hint_get_type ());
			}
		}
	}
#endregion
}
