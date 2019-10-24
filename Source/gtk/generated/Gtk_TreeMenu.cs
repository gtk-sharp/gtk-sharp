// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreeMenu : Gtk.Menu, Gtk.ICellLayout {

		public TreeMenu (IntPtr raw) : base(raw) {}

		protected TreeMenu() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("model")]
		public Gtk.ITreeModel Model {
			get {
				GLib.Value val = GetProperty ("model");
				Gtk.ITreeModel ret = Gtk.TreeModelAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("model", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("root")]
		public Gtk.TreePath Root {
			get {
				GLib.Value val = GetProperty ("root");
				Gtk.TreePath ret = (Gtk.TreePath) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "GtkTreePath");
				SetProperty("root", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("cell-area")]
		public Gtk.CellArea CellArea {
			get {
				GLib.Value val = GetProperty ("cell-area");
				Gtk.CellArea ret = (Gtk.CellArea) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("tearoff")]
		public bool Tearoff {
			get {
				GLib.Value val = GetProperty ("tearoff");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("tearoff", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("wrap-width")]
		public int WrapWidth {
			get {
				GLib.Value val = GetProperty ("wrap-width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("wrap-width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("row-span-column")]
		public int RowSpanColumn {
			get {
				GLib.Value val = GetProperty ("row-span-column");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("row-span-column", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("column-span-column")]
		public int ColumnSpanColumn {
			get {
				GLib.Value val = GetProperty ("column-span-column");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("column-span-column", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("menu-activate")]
		public event Gtk.MenuActivateHandler MenuActivate {
			add {
				this.AddSignalHandler ("menu-activate", value, typeof (Gtk.MenuActivateArgs));
			}
			remove {
				this.RemoveSignalHandler ("menu-activate", value);
			}
		}

		static MenuActivateNativeDelegate MenuActivate_cb_delegate;
		static MenuActivateNativeDelegate MenuActivateVMCallback {
			get {
				if (MenuActivate_cb_delegate == null)
					MenuActivate_cb_delegate = new MenuActivateNativeDelegate (MenuActivate_cb);
				return MenuActivate_cb_delegate;
			}
		}

		static void OverrideMenuActivate (GLib.GType gtype)
		{
			OverrideMenuActivate (gtype, MenuActivateVMCallback);
		}

		static void OverrideMenuActivate (GLib.GType gtype, MenuActivateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "menu-activate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MenuActivateNativeDelegate (IntPtr inst, IntPtr p0);

		static void MenuActivate_cb (IntPtr inst, IntPtr p0)
		{
			try {
				TreeMenu __obj = GLib.Object.GetObject (inst, false) as TreeMenu;
				__obj.OnMenuActivate (GLib.Marshaller.PtrToStringGFree(p0));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TreeMenu), ConnectionMethod="OverrideMenuActivate")]
		protected virtual void OnMenuActivate (string p0)
		{
			InternalMenuActivate (p0);
		}

		private void InternalMenuActivate (string p0)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_add_attribute(IntPtr raw, IntPtr cell, IntPtr attribute, int column);

		public void AddAttribute(Gtk.CellRenderer cell, string attribute, int column) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			gtk_cell_layout_add_attribute(Handle, cell == null ? IntPtr.Zero : cell.Handle, native_attribute, column);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear(IntPtr raw);

		public void Clear() {
			gtk_cell_layout_clear(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear_attributes(IntPtr raw, IntPtr cell);

		public void ClearAttributes(Gtk.CellRenderer cell) {
			gtk_cell_layout_clear_attributes(Handle, cell == null ? IntPtr.Zero : cell.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_area(IntPtr raw);

		public Gtk.CellArea Area { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_area(Handle);
				Gtk.CellArea ret = GLib.Object.GetObject(raw_ret) as Gtk.CellArea;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_cells(IntPtr raw);

		public Gtk.CellRenderer[] Cells { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_cells(Handle);
				Gtk.CellRenderer[] ret = (Gtk.CellRenderer[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(Gtk.CellRenderer));
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_end(IntPtr raw, IntPtr cell, bool expand);

		public void PackEnd(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_end(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_start(IntPtr raw, IntPtr cell, bool expand);

		public void PackStart(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_start(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_reorder(IntPtr raw, IntPtr cell, int position);

		public void Reorder(Gtk.CellRenderer cell, int position) {
			gtk_cell_layout_reorder(Handle, cell == null ? IntPtr.Zero : cell.Handle, position);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_set_cell_data_func(IntPtr raw, IntPtr cell, GtkSharp.CellLayoutDataFuncNative func, IntPtr func_data, GLib.DestroyNotify destroy);

		public void SetCellDataFunc(Gtk.CellRenderer cell, Gtk.CellLayoutDataFunc func) {
			GtkSharp.CellLayoutDataFuncWrapper func_wrapper = new GtkSharp.CellLayoutDataFuncWrapper (func);
			IntPtr func_data;
			GLib.DestroyNotify destroy;
			if (func == null) {
				func_data = IntPtr.Zero;
				destroy = null;
			} else {
				func_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_cell_layout_set_cell_data_func(Handle, cell == null ? IntPtr.Zero : cell.Handle, func_wrapper.NativeDelegate, func_data, destroy);
		}

#endregion
	}
}
