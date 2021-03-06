// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ScrollableAdapter : GLib.GInterfaceAdapter, Gtk.IScrollable {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkScrollableInterface {
			public GetBorderNativeDelegate GetBorder;
		}

		static GtkScrollableInterface iface;

		static ScrollableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ScrollableAdapter));
			iface.GetBorder = new GetBorderNativeDelegate (GetBorder_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetBorderNativeDelegate (IntPtr inst, IntPtr border);

		static bool GetBorder_cb (IntPtr inst, IntPtr border)
		{
			try {
				IScrollableImplementor __obj = GLib.Object.GetObject (inst, false) as IScrollableImplementor;
				bool __result;
				__result = __obj.GetBorder (Gtk.Border.New (border));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkScrollableInterface native_iface = (GtkScrollableInterface) Marshal.PtrToStructure (ifaceptr, typeof (GtkScrollableInterface));
			native_iface.GetBorder = iface.GetBorder;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ScrollableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ScrollableAdapter (IScrollableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ScrollableAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_scrollable_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IScrollable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IScrollable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IScrollableImplementor)
				return new ScrollableAdapter (obj as IScrollableImplementor);
			else if (obj as IScrollable == null)
				return new ScrollableAdapter (obj.Handle);
			else
				return obj as IScrollable;
		}

		public IScrollableImplementor Implementor {
			get {
				return implementor as IScrollableImplementor;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_hadjustment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hadjustment(IntPtr raw, IntPtr hadjustment);

		[GLib.Property ("hadjustment")]
		public Gtk.Adjustment Hadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_hadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_hadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_vadjustment(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vadjustment(IntPtr raw, IntPtr vadjustment);

		[GLib.Property ("vadjustment")]
		public Gtk.Adjustment Vadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_vadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_vadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_hscroll_policy(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("hscroll-policy")]
		public Gtk.ScrollablePolicy HscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_hscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_hscroll_policy(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_vscroll_policy(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("vscroll-policy")]
		public Gtk.ScrollablePolicy VscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_vscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_vscroll_policy(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_scrollable_get_border(IntPtr raw, IntPtr border);

		public bool GetBorder(Gtk.Border border) {
			IntPtr native_border = GLib.Marshaller.StructureToPtrAlloc (border);
			bool raw_ret = gtk_scrollable_get_border(Handle, native_border);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_border);
			return ret;
		}

#endregion
	}
}
