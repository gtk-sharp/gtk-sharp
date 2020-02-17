// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void ListBoxForeachFuncNative(IntPtr box, IntPtr row, IntPtr user_data);

	internal class ListBoxForeachFuncInvoker {

		ListBoxForeachFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ListBoxForeachFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ListBoxForeachFuncInvoker (ListBoxForeachFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ListBoxForeachFuncInvoker (ListBoxForeachFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ListBoxForeachFuncInvoker (ListBoxForeachFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.ListBoxForeachFunc Handler {
			get {
				return new Gtk.ListBoxForeachFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.ListBox box, Gtk.ListBoxRow row)
		{
			native_cb (box == null ? IntPtr.Zero : box.Handle, row == null ? IntPtr.Zero : row.Handle, __data);
		}
	}

	internal class ListBoxForeachFuncWrapper {

		public void NativeCallback (IntPtr box, IntPtr row, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(box) as Gtk.ListBox, GLib.Object.GetObject(row) as Gtk.ListBoxRow);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ListBoxForeachFuncNative NativeDelegate;
		Gtk.ListBoxForeachFunc managed;

		public ListBoxForeachFuncWrapper (Gtk.ListBoxForeachFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ListBoxForeachFuncNative (NativeCallback);
		}

		public static Gtk.ListBoxForeachFunc GetManagedDelegate (ListBoxForeachFuncNative native)
		{
			if (native == null)
				return null;
			ListBoxForeachFuncWrapper wrapper = (ListBoxForeachFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
