// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MarkDeletedHandler(object o, MarkDeletedArgs args);

	public class MarkDeletedArgs : GLib.SignalArgs {
		public Gtk.TextMark Mark{
			get {
				return (Gtk.TextMark) Args [0];
			}
		}

	}
}
