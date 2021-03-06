// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuSectionBox : Gtk.Box {

		public MenuSectionBox (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_section_box_new_toplevel(IntPtr stack, IntPtr model, IntPtr action_namespace, IntPtr popover);

		public MenuSectionBox (Gtk.Stack stack, GLib.MenuModel model, string action_namespace, Gtk.Popover popover) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuSectionBox)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_action_namespace = GLib.Marshaller.StringToPtrGStrdup (action_namespace);
			Raw = gtk_menu_section_box_new_toplevel(stack == null ? IntPtr.Zero : stack.Handle, model == null ? IntPtr.Zero : model.Handle, native_action_namespace, popover == null ? IntPtr.Zero : popover.Handle);
			GLib.Marshaller.Free (native_action_namespace);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_section_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_section_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
