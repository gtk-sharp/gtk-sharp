// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void DragDataDeleteHandler(object o, DragDataDeleteArgs args);

	public class DragDataDeleteArgs : GLib.SignalArgs {
		public Gdk.DragContext Context{
			get {
				return (Gdk.DragContext) Args [0];
			}
		}

	}
}