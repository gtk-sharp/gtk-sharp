// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.DataStreamByteOrderGType))]
	public enum DataStreamByteOrder {

		BigEndian,
		LittleEndian,
		HostEndian,
	}

	internal class DataStreamByteOrderGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_data_stream_byte_order_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_data_stream_byte_order_get_type ());
			}
		}
	}
#endregion
}
