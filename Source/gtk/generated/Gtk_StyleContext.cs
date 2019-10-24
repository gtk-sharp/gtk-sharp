// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StyleContext : GLib.Object {

		public StyleContext (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_new();

		public StyleContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StyleContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_style_context_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_screen(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_screen(IntPtr raw, IntPtr screen);

		[GLib.Property ("screen")]
		public Gdk.Screen Screen {
			get  {
				IntPtr raw_ret = gtk_style_context_get_screen(Handle);
				Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
				return ret;
			}
			set  {
				gtk_style_context_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("paint-clock")]
		public Gdk.FrameClock PaintClock {
			get {
				GLib.Value val = GetProperty ("paint-clock");
				Gdk.FrameClock ret = (Gdk.FrameClock) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("paint-clock", val);
				val.Dispose ();
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_style_context_get_direction(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_direction(IntPtr raw, int direction);

		[Obsolete]
		[GLib.Property ("direction")]
		public Gtk.TextDirection Direction {
			get  {
				int raw_ret = gtk_style_context_get_direction(Handle);
				Gtk.TextDirection ret = (Gtk.TextDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_style_context_set_direction(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_parent(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_parent(IntPtr raw, IntPtr parent);

		[GLib.Property ("parent")]
		public Gtk.StyleContext Parent {
			get  {
				IntPtr raw_ret = gtk_style_context_get_parent(Handle);
				Gtk.StyleContext ret = GLib.Object.GetObject(raw_ret) as Gtk.StyleContext;
				return ret;
			}
			set  {
				gtk_style_context_set_parent(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				StyleContext __obj = GLib.Object.GetObject (inst, false) as StyleContext;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StyleContext), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				unmanaged = (ChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "changed"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_add_class(IntPtr raw, IntPtr class_name);

		public void AddClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			gtk_style_context_add_class(Handle, native_class_name);
			GLib.Marshaller.Free (native_class_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_add_provider(IntPtr raw, IntPtr provider, uint priority);

		public void AddProvider(Gtk.IStyleProvider provider, uint priority) {
			gtk_style_context_add_provider(Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle), priority);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_add_provider_for_screen(IntPtr screen, IntPtr provider, uint priority);

		public static void AddProviderForScreen(Gdk.Screen screen, Gtk.IStyleProvider provider, uint priority) {
			gtk_style_context_add_provider_for_screen(screen == null ? IntPtr.Zero : screen.Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle), priority);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_add_region(IntPtr raw, IntPtr region_name, int flags);

		[Obsolete]
		public void AddRegion(string region_name, Gtk.RegionFlags flags) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			gtk_style_context_add_region(Handle, native_region_name, (int) flags);
			GLib.Marshaller.Free (native_region_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_cancel_animations(IntPtr raw, IntPtr region_id);

		[Obsolete]
		public void CancelAnimations(IntPtr region_id) {
			gtk_style_context_cancel_animations(Handle, region_id);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_background_color(IntPtr raw, int state, IntPtr color);

		[Obsolete]
		public Gdk.RGBA GetBackgroundColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
			gtk_style_context_get_background_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_border(IntPtr raw, int state, IntPtr border);

		public Gtk.Border GetBorder(Gtk.StateFlags state) {
			Gtk.Border border;
			IntPtr native_border = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.Border)));
			gtk_style_context_get_border(Handle, (int) state, native_border);
			border = Gtk.Border.New (native_border);
			Marshal.FreeHGlobal (native_border);
			return border;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_border_color(IntPtr raw, int state, IntPtr color);

		[Obsolete]
		public Gdk.RGBA GetBorderColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
			gtk_style_context_get_border_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_color(IntPtr raw, int state, IntPtr color);

		public Gdk.RGBA GetColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
			gtk_style_context_get_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_font(IntPtr raw, int state);

		[Obsolete]
		public Pango.FontDescription GetFont(Gtk.StateFlags state) {
			IntPtr raw_ret = gtk_style_context_get_font(Handle, (int) state);
			Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_frame_clock(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_frame_clock(IntPtr raw, IntPtr frame_clock);

		public Gdk.FrameClock FrameClock { 
			get {
				IntPtr raw_ret = gtk_style_context_get_frame_clock(Handle);
				Gdk.FrameClock ret = GLib.Object.GetObject(raw_ret) as Gdk.FrameClock;
				return ret;
			}
			set {
				gtk_style_context_set_frame_clock(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_style_context_get_junction_sides(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_junction_sides(IntPtr raw, int sides);

		public Gtk.JunctionSides JunctionSides { 
			get {
				int raw_ret = gtk_style_context_get_junction_sides(Handle);
				Gtk.JunctionSides ret = (Gtk.JunctionSides) raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_junction_sides(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_margin(IntPtr raw, int state, IntPtr margin);

		public Gtk.Border GetMargin(Gtk.StateFlags state) {
			Gtk.Border margin;
			IntPtr native_margin = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.Border)));
			gtk_style_context_get_margin(Handle, (int) state, native_margin);
			margin = Gtk.Border.New (native_margin);
			Marshal.FreeHGlobal (native_margin);
			return margin;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_padding(IntPtr raw, int state, IntPtr padding);

		public Gtk.Border GetPadding(Gtk.StateFlags state) {
			Gtk.Border padding;
			IntPtr native_padding = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.Border)));
			gtk_style_context_get_padding(Handle, (int) state, native_padding);
			padding = Gtk.Border.New (native_padding);
			Marshal.FreeHGlobal (native_padding);
			return padding;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_path(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_path(IntPtr raw, IntPtr path);

		public Gtk.WidgetPath Path { 
			get {
				IntPtr raw_ret = gtk_style_context_get_path(Handle);
				Gtk.WidgetPath ret = raw_ret == IntPtr.Zero ? null : (Gtk.WidgetPath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.WidgetPath), false);
				return ret;
			}
			set {
				gtk_style_context_set_path(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_property(IntPtr raw, IntPtr property, int state, IntPtr value);

		public void GetProperty(string property, Gtk.StateFlags state, GLib.Value value) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gtk_style_context_get_property(Handle, native_property, (int) state, native_value);
			GLib.Marshaller.Free (native_property);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_style_context_get_scale(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_scale(IntPtr raw, int scale);

		public int Scale { 
			get {
				int raw_ret = gtk_style_context_get_scale(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_scale(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_section(IntPtr raw, IntPtr property);

		public Gtk.CssSection GetSection(string property) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr raw_ret = gtk_style_context_get_section(Handle, native_property);
			Gtk.CssSection ret = raw_ret == IntPtr.Zero ? null : (Gtk.CssSection) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.CssSection), false);
			GLib.Marshaller.Free (native_property);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_style_context_get_state(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_state(IntPtr raw, int flags);

		public Gtk.StateFlags State { 
			get {
				int raw_ret = gtk_style_context_get_state(Handle);
				Gtk.StateFlags ret = (Gtk.StateFlags) raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_state(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_get_style_property(IntPtr raw, IntPtr property_name, IntPtr value);

		public GLib.Value GetStyleProperty(string property_name) {
			GLib.Value value;
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			IntPtr native_value = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			gtk_style_context_get_style_property(Handle, native_property_name, native_value);
			GLib.Marshaller.Free (native_property_name);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
			return value;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_style_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_style_context_has_class(IntPtr raw, IntPtr class_name);

		public bool HasClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			bool raw_ret = gtk_style_context_has_class(Handle, native_class_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_class_name);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_style_context_has_region(IntPtr raw, IntPtr region_name, out int flags_return);

		[Obsolete]
		public bool HasRegion(string region_name, out Gtk.RegionFlags flags_return) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			int native_flags_return;
			bool raw_ret = gtk_style_context_has_region(Handle, native_region_name, out native_flags_return);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_region_name);
			flags_return = (Gtk.RegionFlags) native_flags_return;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_invalidate(IntPtr raw);

		[Obsolete]
		public void Invalidate() {
			gtk_style_context_invalidate(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_list_classes(IntPtr raw);

		public string[] ListClasses() {
			IntPtr raw_ret = gtk_style_context_list_classes(Handle);
			string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(string));
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_list_regions(IntPtr raw);

		[Obsolete]
		public string[] ListRegions() {
			IntPtr raw_ret = gtk_style_context_list_regions(Handle);
			string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(string));
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_style_context_lookup_color(IntPtr raw, IntPtr color_name, IntPtr color);

		public bool LookupColor(string color_name, out Gdk.RGBA color) {
			IntPtr native_color_name = GLib.Marshaller.StringToPtrGStrdup (color_name);
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
			bool raw_ret = gtk_style_context_lookup_color(Handle, native_color_name, native_color);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_color_name);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_lookup_icon_set(IntPtr raw, IntPtr stock_id);

		[Obsolete]
		public Gtk.IconSet LookupIconSet(string stock_id) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_style_context_lookup_icon_set(Handle, native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_notify_state_change(IntPtr raw, IntPtr window, IntPtr region_id, int state, bool state_value);

		[Obsolete]
		public void NotifyStateChange(Gdk.Window window, IntPtr region_id, Gtk.StateType state, bool state_value) {
			gtk_style_context_notify_state_change(Handle, window == null ? IntPtr.Zero : window.Handle, region_id, (int) state, state_value);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_pop_animatable_region(IntPtr raw);

		[Obsolete]
		public void PopAnimatableRegion() {
			gtk_style_context_pop_animatable_region(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_push_animatable_region(IntPtr raw, IntPtr region_id);

		[Obsolete]
		public void PushAnimatableRegion(IntPtr region_id) {
			gtk_style_context_push_animatable_region(Handle, region_id);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_remove_class(IntPtr raw, IntPtr class_name);

		public void RemoveClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			gtk_style_context_remove_class(Handle, native_class_name);
			GLib.Marshaller.Free (native_class_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_remove_provider(IntPtr raw, IntPtr provider);

		public void RemoveProvider(Gtk.IStyleProvider provider) {
			gtk_style_context_remove_provider(Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_remove_provider_for_screen(IntPtr screen, IntPtr provider);

		public static void RemoveProviderForScreen(Gdk.Screen screen, Gtk.IStyleProvider provider) {
			gtk_style_context_remove_provider_for_screen(screen == null ? IntPtr.Zero : screen.Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_remove_region(IntPtr raw, IntPtr region_name);

		[Obsolete]
		public void RemoveRegion(string region_name) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			gtk_style_context_remove_region(Handle, native_region_name);
			GLib.Marshaller.Free (native_region_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_reset_widgets(IntPtr screen);

		public static void ResetWidgets(Gdk.Screen screen) {
			gtk_style_context_reset_widgets(screen == null ? IntPtr.Zero : screen.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_restore(IntPtr raw);

		public void Restore() {
			gtk_style_context_restore(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_save(IntPtr raw);

		public void Save() {
			gtk_style_context_save(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_scroll_animations(IntPtr raw, IntPtr window, int dx, int dy);

		[Obsolete]
		public void ScrollAnimations(Gdk.Window window, int dx, int dy) {
			gtk_style_context_scroll_animations(Handle, window == null ? IntPtr.Zero : window.Handle, dx, dy);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_style_context_set_background(IntPtr raw, IntPtr window);

		[Obsolete]
		public Gdk.Window Background { 
			set {
				gtk_style_context_set_background(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_style_context_state_is_running(IntPtr raw, int state, out double progress);

		[Obsolete]
		public bool StateIsRunning(Gtk.StateType state, out double progress) {
			bool raw_ret = gtk_style_context_state_is_running(Handle, (int) state, out progress);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_to_string(IntPtr raw, int flags);

		public string ToString(Gtk.StyleContextPrintFlags flags) {
			IntPtr raw_ret = gtk_style_context_to_string(Handle, (int) flags);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
