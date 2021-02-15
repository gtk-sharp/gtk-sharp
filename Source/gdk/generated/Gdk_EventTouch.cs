// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct EventTouch : IEquatable<EventTouch> {

		public Gdk.EventType Type;
		private IntPtr _window;
		public Gdk.Window Window {
			get {
				return GLib.Object.GetObject(_window) as Gdk.Window;
			}
			set {
				_window = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public sbyte SendEvent;
		public uint Time;
		public double X;
		public double Y;
		private IntPtr _axes;
		public uint State;
		private IntPtr _sequence;
		public Gdk.EventSequence Sequence {
			get {
				return _sequence == IntPtr.Zero ? null : (Gdk.EventSequence) GLib.Opaque.GetOpaque (_sequence, typeof (Gdk.EventSequence), false);
			}
			set {
				_sequence = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public bool EmulatingPointer;
		private IntPtr _device;
		public Gdk.Device Device {
			get {
				return GLib.Object.GetObject(_device) as Gdk.Device;
			}
			set {
				_device = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public double XRoot;
		public double YRoot;

		public static Gdk.EventTouch Zero = new Gdk.EventTouch ();

		public static Gdk.EventTouch New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.EventTouch.Zero;
			return (Gdk.EventTouch) Marshal.PtrToStructure (raw, typeof (Gdk.EventTouch));
		}

		public bool Equals (EventTouch other)
		{
			return true && Type.Equals (other.Type) && Window.Equals (other.Window) && SendEvent.Equals (other.SendEvent) && Time.Equals (other.Time) && X.Equals (other.X) && Y.Equals (other.Y) && _axes.Equals (other._axes) && State.Equals (other.State) && Sequence.Equals (other.Sequence) && EmulatingPointer.Equals (other.EmulatingPointer) && Device.Equals (other.Device) && XRoot.Equals (other.XRoot) && YRoot.Equals (other.YRoot);
		}

		public override bool Equals (object other)
		{
			return other is EventTouch && Equals ((EventTouch) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Type.GetHashCode () ^ Window.GetHashCode () ^ SendEvent.GetHashCode () ^ Time.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ _axes.GetHashCode () ^ State.GetHashCode () ^ Sequence.GetHashCode () ^ EmulatingPointer.GetHashCode () ^ Device.GetHashCode () ^ XRoot.GetHashCode () ^ YRoot.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}