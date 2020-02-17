// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct InputVector : IEquatable<InputVector> {

		private IntPtr _buffer;
		private UIntPtr size;
		public ulong Size {
			get {
				return (ulong) size;
			}
			set {
				size = new UIntPtr (value);
			}
		}

		public static GLib.InputVector Zero = new GLib.InputVector ();

		public static GLib.InputVector New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.InputVector.Zero;
			return (GLib.InputVector) Marshal.PtrToStructure (raw, typeof (GLib.InputVector));
		}

		public bool Equals (InputVector other)
		{
			return true && _buffer.Equals (other._buffer) && Size.Equals (other.Size);
		}

		public override bool Equals (object other)
		{
			return other is InputVector && Equals ((InputVector) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ _buffer.GetHashCode () ^ Size.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
