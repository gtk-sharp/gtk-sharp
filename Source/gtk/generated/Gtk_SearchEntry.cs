// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SearchEntry : Gtk.Entry {

		public SearchEntry (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_search_entry_new();

		public SearchEntry () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SearchEntry)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_search_entry_new();
		}

		[GLib.Signal("next-match")]
		public event System.EventHandler NextMatch {
			add {
				this.AddSignalHandler ("next-match", value);
			}
			remove {
				this.RemoveSignalHandler ("next-match", value);
			}
		}

		[GLib.Signal("search-changed")]
		public event System.EventHandler SearchChanged {
			add {
				this.AddSignalHandler ("search-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("search-changed", value);
			}
		}

		[GLib.Signal("stop-search")]
		public event System.EventHandler StopSearch {
			add {
				this.AddSignalHandler ("stop-search", value);
			}
			remove {
				this.RemoveSignalHandler ("stop-search", value);
			}
		}

		[GLib.Signal("previous-match")]
		public event System.EventHandler PreviousMatch {
			add {
				this.AddSignalHandler ("previous-match", value);
			}
			remove {
				this.RemoveSignalHandler ("previous-match", value);
			}
		}

		static SearchChangedNativeDelegate SearchChanged_cb_delegate;
		static SearchChangedNativeDelegate SearchChangedVMCallback {
			get {
				if (SearchChanged_cb_delegate == null)
					SearchChanged_cb_delegate = new SearchChangedNativeDelegate (SearchChanged_cb);
				return SearchChanged_cb_delegate;
			}
		}

		static void OverrideSearchChanged (GLib.GType gtype)
		{
			OverrideSearchChanged (gtype, SearchChangedVMCallback);
		}

		static void OverrideSearchChanged (GLib.GType gtype, SearchChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("search_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SearchChangedNativeDelegate (IntPtr inst);

		static void SearchChanged_cb (IntPtr inst)
		{
			try {
				SearchEntry __obj = GLib.Object.GetObject (inst, false) as SearchEntry;
				__obj.OnSearchChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SearchEntry), ConnectionMethod="OverrideSearchChanged")]
		protected virtual void OnSearchChanged ()
		{
			InternalSearchChanged ();
		}

		private void InternalSearchChanged ()
		{
			SearchChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("search_changed"));
				unmanaged = (SearchChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SearchChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NextMatchNativeDelegate NextMatch_cb_delegate;
		static NextMatchNativeDelegate NextMatchVMCallback {
			get {
				if (NextMatch_cb_delegate == null)
					NextMatch_cb_delegate = new NextMatchNativeDelegate (NextMatch_cb);
				return NextMatch_cb_delegate;
			}
		}

		static void OverrideNextMatch (GLib.GType gtype)
		{
			OverrideNextMatch (gtype, NextMatchVMCallback);
		}

		static void OverrideNextMatch (GLib.GType gtype, NextMatchNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_match"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NextMatchNativeDelegate (IntPtr inst);

		static void NextMatch_cb (IntPtr inst)
		{
			try {
				SearchEntry __obj = GLib.Object.GetObject (inst, false) as SearchEntry;
				__obj.OnNextMatch ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SearchEntry), ConnectionMethod="OverrideNextMatch")]
		protected virtual void OnNextMatch ()
		{
			InternalNextMatch ();
		}

		private void InternalNextMatch ()
		{
			NextMatchNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_match"));
				unmanaged = (NextMatchNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextMatchNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PreviousMatchNativeDelegate PreviousMatch_cb_delegate;
		static PreviousMatchNativeDelegate PreviousMatchVMCallback {
			get {
				if (PreviousMatch_cb_delegate == null)
					PreviousMatch_cb_delegate = new PreviousMatchNativeDelegate (PreviousMatch_cb);
				return PreviousMatch_cb_delegate;
			}
		}

		static void OverridePreviousMatch (GLib.GType gtype)
		{
			OverridePreviousMatch (gtype, PreviousMatchVMCallback);
		}

		static void OverridePreviousMatch (GLib.GType gtype, PreviousMatchNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("previous_match"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PreviousMatchNativeDelegate (IntPtr inst);

		static void PreviousMatch_cb (IntPtr inst)
		{
			try {
				SearchEntry __obj = GLib.Object.GetObject (inst, false) as SearchEntry;
				__obj.OnPreviousMatch ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SearchEntry), ConnectionMethod="OverridePreviousMatch")]
		protected virtual void OnPreviousMatch ()
		{
			InternalPreviousMatch ();
		}

		private void InternalPreviousMatch ()
		{
			PreviousMatchNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("previous_match"));
				unmanaged = (PreviousMatchNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(PreviousMatchNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static StopSearchNativeDelegate StopSearch_cb_delegate;
		static StopSearchNativeDelegate StopSearchVMCallback {
			get {
				if (StopSearch_cb_delegate == null)
					StopSearch_cb_delegate = new StopSearchNativeDelegate (StopSearch_cb);
				return StopSearch_cb_delegate;
			}
		}

		static void OverrideStopSearch (GLib.GType gtype)
		{
			OverrideStopSearch (gtype, StopSearchVMCallback);
		}

		static void OverrideStopSearch (GLib.GType gtype, StopSearchNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("stop_search"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StopSearchNativeDelegate (IntPtr inst);

		static void StopSearch_cb (IntPtr inst)
		{
			try {
				SearchEntry __obj = GLib.Object.GetObject (inst, false) as SearchEntry;
				__obj.OnStopSearch ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SearchEntry), ConnectionMethod="OverrideStopSearch")]
		protected virtual void OnStopSearch ()
		{
			InternalStopSearch ();
		}

		private void InternalStopSearch ()
		{
			StopSearchNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("stop_search"));
				unmanaged = (StopSearchNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StopSearchNativeDelegate));
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
						new GLib.AbiField("search_changed"
							, Gtk.Entry.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // search_changed
							, null
							, "next_match"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next_match"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_match
							, "search_changed"
							, "previous_match"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("previous_match"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // previous_match
							, "next_match"
							, "stop_search"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("stop_search"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // stop_search
							, "previous_match"
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
		static extern IntPtr gtk_search_entry_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_search_entry_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_search_entry_handle_event(IntPtr raw, IntPtr evnt);

		public bool HandleEvent(Gdk.Event evnt) {
			bool raw_ret = gtk_search_entry_handle_event(Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Entry.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
