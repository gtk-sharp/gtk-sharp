// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLContext : GLib.Object {

		public GLContext (IntPtr raw) : base(raw) {}

		protected GLContext() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_gl_context_get_display(IntPtr raw);

		[GLib.Property ("display")]
		public Gdk.Display Display {
			get  {
				IntPtr raw_ret = gdk_gl_context_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_gl_context_get_window(IntPtr raw);

		[GLib.Property ("window")]
		public Gdk.Window Window {
			get  {
				IntPtr raw_ret = gdk_gl_context_get_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		static RealizeNativeDelegate Realize_cb_delegate;
		static RealizeNativeDelegate RealizeVMCallback {
			get {
				if (Realize_cb_delegate == null)
					Realize_cb_delegate = new RealizeNativeDelegate (Realize_cb);
				return Realize_cb_delegate;
			}
		}

		static void OverrideRealize (GLib.GType gtype)
		{
			OverrideRealize (gtype, RealizeVMCallback);
		}

		static void OverrideRealize (GLib.GType gtype, RealizeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("realize"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RealizeNativeDelegate (IntPtr inst, out IntPtr error);

		static bool Realize_cb (IntPtr inst, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnRealize ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.GLContext), ConnectionMethod="OverrideRealize")]
		protected virtual bool OnRealize ()
		{
			return InternalRealize ();
		}

		private bool InternalRealize ()
		{
			RealizeNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("realize"));
				unmanaged = (RealizeNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(RealizeNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, out error);
			return __result;
		}

		static EndFrameNativeDelegate EndFrame_cb_delegate;
		static EndFrameNativeDelegate EndFrameVMCallback {
			get {
				if (EndFrame_cb_delegate == null)
					EndFrame_cb_delegate = new EndFrameNativeDelegate (EndFrame_cb);
				return EndFrame_cb_delegate;
			}
		}

		static void OverrideEndFrame (GLib.GType gtype)
		{
			OverrideEndFrame (gtype, EndFrameVMCallback);
		}

		static void OverrideEndFrame (GLib.GType gtype, EndFrameNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("end_frame"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EndFrameNativeDelegate (IntPtr inst, IntPtr painted, IntPtr damage);

		static void EndFrame_cb (IntPtr inst, IntPtr painted, IntPtr damage)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				__obj.OnEndFrame (new Cairo.Region(painted), new Cairo.Region(damage));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.GLContext), ConnectionMethod="OverrideEndFrame")]
		protected virtual void OnEndFrame (Cairo.Region painted, Cairo.Region damage)
		{
			InternalEndFrame (painted, damage);
		}

		private void InternalEndFrame (Cairo.Region painted, Cairo.Region damage)
		{
			EndFrameNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("end_frame"));
				unmanaged = (EndFrameNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EndFrameNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, painted == null ? IntPtr.Zero : painted.Handle, damage == null ? IntPtr.Zero : damage.Handle);
		}

		static TextureFromSurfaceNativeDelegate TextureFromSurface_cb_delegate;
		static TextureFromSurfaceNativeDelegate TextureFromSurfaceVMCallback {
			get {
				if (TextureFromSurface_cb_delegate == null)
					TextureFromSurface_cb_delegate = new TextureFromSurfaceNativeDelegate (TextureFromSurface_cb);
				return TextureFromSurface_cb_delegate;
			}
		}

		static void OverrideTextureFromSurface (GLib.GType gtype)
		{
			OverrideTextureFromSurface (gtype, TextureFromSurfaceVMCallback);
		}

		static void OverrideTextureFromSurface (GLib.GType gtype, TextureFromSurfaceNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("texture_from_surface"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool TextureFromSurfaceNativeDelegate (IntPtr inst, IntPtr surface, IntPtr region);

		static bool TextureFromSurface_cb (IntPtr inst, IntPtr surface, IntPtr region)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnTextureFromSurface (Cairo.Surface.Lookup (surface, true), new Cairo.Region(region));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.GLContext), ConnectionMethod="OverrideTextureFromSurface")]
		protected virtual bool OnTextureFromSurface (Cairo.Surface surface, Cairo.Region region)
		{
			return InternalTextureFromSurface (surface, region);
		}

		private bool InternalTextureFromSurface (Cairo.Surface surface, Cairo.Region region)
		{
			TextureFromSurfaceNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("texture_from_surface"));
				unmanaged = (TextureFromSurfaceNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TextureFromSurfaceNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, surface.Handle, region == null ? IntPtr.Zero : region.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("realize"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // realize
							, null
							, "end_frame"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("end_frame"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // end_frame
							, "realize"
							, "texture_from_surface"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("texture_from_surface"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // texture_from_surface
							, "end_frame"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_clear_current();

		public static void ClearCurrent() {
			gdk_gl_context_clear_current();
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_gl_context_get_current();

		public static Gdk.GLContext Current { 
			get {
				IntPtr raw_ret = gdk_gl_context_get_current();
				Gdk.GLContext ret = GLib.Object.GetObject(raw_ret) as Gdk.GLContext;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_gl_context_get_debug_enabled(IntPtr raw);

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_set_debug_enabled(IntPtr raw, bool enabled);

		public bool DebugEnabled { 
			get {
				bool raw_ret = gdk_gl_context_get_debug_enabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gdk_gl_context_set_debug_enabled(Handle, value);
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_gl_context_get_forward_compatible(IntPtr raw);

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_set_forward_compatible(IntPtr raw, bool compatible);

		public bool ForwardCompatible { 
			get {
				bool raw_ret = gdk_gl_context_get_forward_compatible(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gdk_gl_context_set_forward_compatible(Handle, value);
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_get_required_version(IntPtr raw, out int major, out int minor);

		public void GetRequiredVersion(out int major, out int minor) {
			gdk_gl_context_get_required_version(Handle, out major, out minor);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_gl_context_get_shared_context(IntPtr raw);

		public Gdk.GLContext SharedContext { 
			get {
				IntPtr raw_ret = gdk_gl_context_get_shared_context(Handle);
				Gdk.GLContext ret = GLib.Object.GetObject(raw_ret) as Gdk.GLContext;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_gl_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_gl_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_gl_context_get_use_es(IntPtr raw);

		public bool UseEs { 
			get {
				bool raw_ret = gdk_gl_context_get_use_es(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_get_version(IntPtr raw, out int major, out int minor);

		public void GetVersion(out int major, out int minor) {
			gdk_gl_context_get_version(Handle, out major, out minor);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_gl_context_is_legacy(IntPtr raw);

		public bool IsLegacy { 
			get {
				bool raw_ret = gdk_gl_context_is_legacy(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_make_current(IntPtr raw);

		public void MakeCurrent() {
			gdk_gl_context_make_current(Handle);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gdk_gl_context_realize(IntPtr raw, out IntPtr error);

		public unsafe bool Realize() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gdk_gl_context_realize(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_set_required_version(IntPtr raw, int major, int minor);

		public void SetRequiredVersion(int major, int minor) {
			gdk_gl_context_set_required_version(Handle, major, minor);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_gl_context_set_use_es(IntPtr raw, int use_es);

		public void SetUseEs(int use_es) {
			gdk_gl_context_set_use_es(Handle, use_es);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
