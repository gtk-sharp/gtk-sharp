// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.CalendarDisplayOptionsGType))]
	public enum CalendarDisplayOptions {

		ShowHeading = 1 << 0,
		ShowDayNames = 1 << 1,
		NoMonthChange = 1 << 2,
		ShowWeekNumbers = 1 << 3,
		ShowDetails = 1 << 5,
	}

	internal class CalendarDisplayOptionsGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_calendar_display_options_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_calendar_display_options_get_type ());
			}
		}
	}
#endregion
}
