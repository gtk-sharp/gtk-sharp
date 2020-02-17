// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool TickCallbackNative(IntPtr widget, IntPtr frame_clock, IntPtr user_data);

	internal class TickCallbackInvoker {

		TickCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TickCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TickCallbackInvoker (TickCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TickCallbackInvoker (TickCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TickCallbackInvoker (TickCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TickCallback Handler {
			get {
				return new Gtk.TickCallback(InvokeNative);
			}
		}

		bool InvokeNative (Gtk.Widget widget, Gdk.FrameClock frame_clock)
		{
			bool __result = native_cb (widget == null ? IntPtr.Zero : widget.Handle, frame_clock == null ? IntPtr.Zero : frame_clock.Handle, __data);
			return __result;
		}
	}

	internal class TickCallbackWrapper {

		public bool NativeCallback (IntPtr widget, IntPtr frame_clock, IntPtr user_data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(widget) as Gtk.Widget, GLib.Object.GetObject(frame_clock) as Gdk.FrameClock);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TickCallbackNative NativeDelegate;
		Gtk.TickCallback managed;

		public TickCallbackWrapper (Gtk.TickCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TickCallbackNative (NativeCallback);
		}

		public static Gtk.TickCallback GetManagedDelegate (TickCallbackNative native)
		{
			if (native == null)
				return null;
			TickCallbackWrapper wrapper = (TickCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
