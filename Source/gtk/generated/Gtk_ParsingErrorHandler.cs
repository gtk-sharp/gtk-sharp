// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ParsingErrorHandler(object o, ParsingErrorArgs args);

	public class ParsingErrorArgs : GLib.SignalArgs {
		public Gtk.CssSection Section{
			get {
				return (Gtk.CssSection) Args [0];
			}
		}

		public IntPtr Error{
			get {
				return (IntPtr) Args [1];
			}
		}

	}
}
