// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void SurroundingDeletedHandler(object o, SurroundingDeletedArgs args);

	public class SurroundingDeletedArgs : GLib.SignalArgs {
		public int Offset{
			get {
				return (int) Args [0];
			}
		}

		public int NChars{
			get {
				return (int) Args [1];
			}
		}

	}
}