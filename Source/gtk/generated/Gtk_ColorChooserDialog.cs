// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ColorChooserDialog : Gtk.Dialog, Gtk.IColorChooser {

		public ColorChooserDialog (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_chooser_dialog_new(IntPtr title, IntPtr parent);

		public ColorChooserDialog (string title, Gtk.Window parent) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ColorChooserDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				if (parent != null) {
					names.Add ("parent");
					vals.Add (new GLib.Value (parent));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			Raw = gtk_color_chooser_dialog_new(native_title, parent == null ? IntPtr.Zero : parent.Handle);
			GLib.Marshaller.Free (native_title);
		}

		[GLib.Property ("show-editor")]
		public bool ShowEditor {
			get {
				GLib.Value val = GetProperty ("show-editor");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-editor", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Dialog.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
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

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_chooser_dialog_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_color_chooser_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_add_palette(IntPtr raw, int orientation, int colors_per_line, int n_colors, IntPtr colors);

		public void AddPalette(Gtk.Orientation orientation, int colors_per_line, int n_colors, Gdk.RGBA colors) {
			IntPtr native_colors = GLib.Marshaller.StructureToPtrAlloc (colors);
			gtk_color_chooser_add_palette(Handle, (int) orientation, colors_per_line, n_colors, native_colors);
			Marshal.FreeHGlobal (native_colors);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_get_rgba(IntPtr raw, IntPtr color);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_set_rgba(IntPtr raw, IntPtr value);

		[GLib.Property ("rgba")]
		public Gdk.RGBA Rgba {
			get  {
				Gdk.RGBA color;
				IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
				gtk_color_chooser_get_rgba(Handle, native_color);
				color = Gdk.RGBA.New (native_color);
				Marshal.FreeHGlobal (native_color);
				return color;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gtk_color_chooser_set_rgba(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_color_chooser_get_use_alpha(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_set_use_alpha(IntPtr raw, bool use_alpha);

		[GLib.Property ("use-alpha")]
		public bool UseAlpha {
			get  {
				bool raw_ret = gtk_color_chooser_get_use_alpha(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_color_chooser_set_use_alpha(Handle, value);
			}
		}

		[GLib.Signal("color-activated")]
		public event Gtk.ColorActivatedHandler ColorActivated {
			add {
				this.AddSignalHandler ("color-activated", value, typeof (Gtk.ColorActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("color-activated", value);
			}
		}

		static ColorActivatedNativeDelegate ColorActivated_cb_delegate;
		static ColorActivatedNativeDelegate ColorActivatedVMCallback {
			get {
				if (ColorActivated_cb_delegate == null)
					ColorActivated_cb_delegate = new ColorActivatedNativeDelegate (ColorActivated_cb);
				return ColorActivated_cb_delegate;
			}
		}

		static void OverrideColorActivated (GLib.GType gtype)
		{
			OverrideColorActivated (gtype, ColorActivatedVMCallback);
		}

		static void OverrideColorActivated (GLib.GType gtype, ColorActivatedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "color-activated", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ColorActivatedNativeDelegate (IntPtr inst, IntPtr color);

		static void ColorActivated_cb (IntPtr inst, IntPtr color)
		{
			try {
				Gtk.ColorChooserDialog __obj = GLib.Object.GetObject (inst, false) as Gtk.ColorChooserDialog;
				__obj.OnColorActivated (Gdk.RGBA.New (color));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ColorChooserDialog), ConnectionMethod="OverrideColorActivated")]
		protected virtual void OnColorActivated (Gdk.RGBA color)
		{
			InternalColorActivated (color);
		}

		private void InternalColorActivated (Gdk.RGBA color)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (color);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Dialog.abi_info.Fields
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
