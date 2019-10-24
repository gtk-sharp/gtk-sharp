// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class EntryCompletion : GLib.Object, Gtk.ICellLayout {

		public EntryCompletion (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_new();

		public EntryCompletion () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EntryCompletion)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_entry_completion_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_new_with_area(IntPtr area);

		public EntryCompletion (Gtk.CellArea area) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EntryCompletion)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_entry_completion_new_with_area(area == null ? IntPtr.Zero : area.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_get_model(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_model(IntPtr raw, IntPtr model);

		[GLib.Property ("model")]
		public Gtk.ITreeModel Model {
			get  {
				IntPtr raw_ret = gtk_entry_completion_get_model(Handle);
				Gtk.ITreeModel ret = Gtk.TreeModelAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_entry_completion_set_model(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as Gtk.TreeModelAdapter).Handle));
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_entry_completion_get_minimum_key_length(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_minimum_key_length(IntPtr raw, int length);

		[GLib.Property ("minimum-key-length")]
		public int MinimumKeyLength {
			get  {
				int raw_ret = gtk_entry_completion_get_minimum_key_length(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_minimum_key_length(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_entry_completion_get_text_column(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_text_column(IntPtr raw, int column);

		[GLib.Property ("text-column")]
		public int TextColumn {
			get  {
				int raw_ret = gtk_entry_completion_get_text_column(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_text_column(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_entry_completion_get_inline_completion(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_inline_completion(IntPtr raw, bool inline_completion);

		[GLib.Property ("inline-completion")]
		public bool InlineCompletion {
			get  {
				bool raw_ret = gtk_entry_completion_get_inline_completion(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_inline_completion(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_entry_completion_get_popup_completion(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_popup_completion(IntPtr raw, bool popup_completion);

		[GLib.Property ("popup-completion")]
		public bool PopupCompletion {
			get  {
				bool raw_ret = gtk_entry_completion_get_popup_completion(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_popup_completion(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_entry_completion_get_popup_set_width(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_popup_set_width(IntPtr raw, bool popup_set_width);

		[GLib.Property ("popup-set-width")]
		public bool PopupSetWidth {
			get  {
				bool raw_ret = gtk_entry_completion_get_popup_set_width(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_popup_set_width(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_entry_completion_get_popup_single_match(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_popup_single_match(IntPtr raw, bool popup_single_match);

		[GLib.Property ("popup-single-match")]
		public bool PopupSingleMatch {
			get  {
				bool raw_ret = gtk_entry_completion_get_popup_single_match(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_popup_single_match(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_entry_completion_get_inline_selection(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_inline_selection(IntPtr raw, bool inline_selection);

		[GLib.Property ("inline-selection")]
		public bool InlineSelection {
			get  {
				bool raw_ret = gtk_entry_completion_get_inline_selection(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_entry_completion_set_inline_selection(Handle, value);
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

		[GLib.Signal("insert-prefix")]
		public event Gtk.PrefixInsertedHandler PrefixInserted {
			add {
				this.AddSignalHandler ("insert-prefix", value, typeof (Gtk.PrefixInsertedArgs));
			}
			remove {
				this.RemoveSignalHandler ("insert-prefix", value);
			}
		}

		[GLib.Signal("no-matches")]
		public event System.EventHandler NoMatches {
			add {
				this.AddSignalHandler ("no-matches", value);
			}
			remove {
				this.RemoveSignalHandler ("no-matches", value);
			}
		}

		[GLib.Signal("match-selected")]
		public event Gtk.MatchSelectedHandler MatchSelected {
			add {
				this.AddSignalHandler ("match-selected", value, typeof (Gtk.MatchSelectedArgs));
			}
			remove {
				this.RemoveSignalHandler ("match-selected", value);
			}
		}

		[GLib.Signal("cursor-on-match")]
		public event Gtk.CursorOnMatchHandler CursorOnMatch {
			add {
				this.AddSignalHandler ("cursor-on-match", value, typeof (Gtk.CursorOnMatchArgs));
			}
			remove {
				this.RemoveSignalHandler ("cursor-on-match", value);
			}
		}

		[GLib.Signal("action-activated")]
		public event Gtk.ActionActivatedHandler ActionActivated {
			add {
				this.AddSignalHandler ("action-activated", value, typeof (Gtk.ActionActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("action-activated", value);
			}
		}

		static MatchSelectedNativeDelegate MatchSelected_cb_delegate;
		static MatchSelectedNativeDelegate MatchSelectedVMCallback {
			get {
				if (MatchSelected_cb_delegate == null)
					MatchSelected_cb_delegate = new MatchSelectedNativeDelegate (MatchSelected_cb);
				return MatchSelected_cb_delegate;
			}
		}

		static void OverrideMatchSelected (GLib.GType gtype)
		{
			OverrideMatchSelected (gtype, MatchSelectedVMCallback);
		}

		static void OverrideMatchSelected (GLib.GType gtype, MatchSelectedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("match_selected"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool MatchSelectedNativeDelegate (IntPtr inst, IntPtr model, IntPtr iter);

		static bool MatchSelected_cb (IntPtr inst, IntPtr model, IntPtr iter)
		{
			try {
				EntryCompletion __obj = GLib.Object.GetObject (inst, false) as EntryCompletion;
				bool __result;
				__result = __obj.OnMatchSelected (Gtk.TreeModelAdapter.GetObject (model, false), Gtk.TreeIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.EntryCompletion), ConnectionMethod="OverrideMatchSelected")]
		protected virtual bool OnMatchSelected (Gtk.ITreeModel model, Gtk.TreeIter iter)
		{
			return InternalMatchSelected (model, iter);
		}

		private bool InternalMatchSelected (Gtk.ITreeModel model, Gtk.TreeIter iter)
		{
			MatchSelectedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("match_selected"));
				unmanaged = (MatchSelectedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(MatchSelectedNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool __result = unmanaged (this.Handle, model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), native_iter);
			Marshal.FreeHGlobal (native_iter);
			return __result;
		}

		static ActionActivatedNativeDelegate ActionActivated_cb_delegate;
		static ActionActivatedNativeDelegate ActionActivatedVMCallback {
			get {
				if (ActionActivated_cb_delegate == null)
					ActionActivated_cb_delegate = new ActionActivatedNativeDelegate (ActionActivated_cb);
				return ActionActivated_cb_delegate;
			}
		}

		static void OverrideActionActivated (GLib.GType gtype)
		{
			OverrideActionActivated (gtype, ActionActivatedVMCallback);
		}

		static void OverrideActionActivated (GLib.GType gtype, ActionActivatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("action_activated"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionActivatedNativeDelegate (IntPtr inst, int index_);

		static void ActionActivated_cb (IntPtr inst, int index_)
		{
			try {
				EntryCompletion __obj = GLib.Object.GetObject (inst, false) as EntryCompletion;
				__obj.OnActionActivated (index_);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.EntryCompletion), ConnectionMethod="OverrideActionActivated")]
		protected virtual void OnActionActivated (int index_)
		{
			InternalActionActivated (index_);
		}

		private void InternalActionActivated (int index_)
		{
			ActionActivatedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("action_activated"));
				unmanaged = (ActionActivatedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActionActivatedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, index_);
		}

		static PrefixInsertedNativeDelegate PrefixInserted_cb_delegate;
		static PrefixInsertedNativeDelegate PrefixInsertedVMCallback {
			get {
				if (PrefixInserted_cb_delegate == null)
					PrefixInserted_cb_delegate = new PrefixInsertedNativeDelegate (PrefixInserted_cb);
				return PrefixInserted_cb_delegate;
			}
		}

		static void OverridePrefixInserted (GLib.GType gtype)
		{
			OverridePrefixInserted (gtype, PrefixInsertedVMCallback);
		}

		static void OverridePrefixInserted (GLib.GType gtype, PrefixInsertedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("insert_prefix"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool PrefixInsertedNativeDelegate (IntPtr inst, IntPtr prefix);

		static bool PrefixInserted_cb (IntPtr inst, IntPtr prefix)
		{
			try {
				EntryCompletion __obj = GLib.Object.GetObject (inst, false) as EntryCompletion;
				bool __result;
				__result = __obj.OnPrefixInserted (GLib.Marshaller.Utf8PtrToString (prefix));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.EntryCompletion), ConnectionMethod="OverridePrefixInserted")]
		protected virtual bool OnPrefixInserted (string prefix)
		{
			return InternalPrefixInserted (prefix);
		}

		private bool InternalPrefixInserted (string prefix)
		{
			PrefixInsertedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("insert_prefix"));
				unmanaged = (PrefixInsertedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(PrefixInsertedNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_prefix = GLib.Marshaller.StringToPtrGStrdup (prefix);
			bool __result = unmanaged (this.Handle, native_prefix);
			GLib.Marshaller.Free (native_prefix);
			return __result;
		}

		static CursorOnMatchNativeDelegate CursorOnMatch_cb_delegate;
		static CursorOnMatchNativeDelegate CursorOnMatchVMCallback {
			get {
				if (CursorOnMatch_cb_delegate == null)
					CursorOnMatch_cb_delegate = new CursorOnMatchNativeDelegate (CursorOnMatch_cb);
				return CursorOnMatch_cb_delegate;
			}
		}

		static void OverrideCursorOnMatch (GLib.GType gtype)
		{
			OverrideCursorOnMatch (gtype, CursorOnMatchVMCallback);
		}

		static void OverrideCursorOnMatch (GLib.GType gtype, CursorOnMatchNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("cursor_on_match"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CursorOnMatchNativeDelegate (IntPtr inst, IntPtr model, IntPtr iter);

		static bool CursorOnMatch_cb (IntPtr inst, IntPtr model, IntPtr iter)
		{
			try {
				EntryCompletion __obj = GLib.Object.GetObject (inst, false) as EntryCompletion;
				bool __result;
				__result = __obj.OnCursorOnMatch (Gtk.TreeModelAdapter.GetObject (model, false), Gtk.TreeIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.EntryCompletion), ConnectionMethod="OverrideCursorOnMatch")]
		protected virtual bool OnCursorOnMatch (Gtk.ITreeModel model, Gtk.TreeIter iter)
		{
			return InternalCursorOnMatch (model, iter);
		}

		private bool InternalCursorOnMatch (Gtk.ITreeModel model, Gtk.TreeIter iter)
		{
			CursorOnMatchNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("cursor_on_match"));
				unmanaged = (CursorOnMatchNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CursorOnMatchNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool __result = unmanaged (this.Handle, model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), native_iter);
			Marshal.FreeHGlobal (native_iter);
			return __result;
		}

		static NoMatchesNativeDelegate NoMatches_cb_delegate;
		static NoMatchesNativeDelegate NoMatchesVMCallback {
			get {
				if (NoMatches_cb_delegate == null)
					NoMatches_cb_delegate = new NoMatchesNativeDelegate (NoMatches_cb);
				return NoMatches_cb_delegate;
			}
		}

		static void OverrideNoMatches (GLib.GType gtype)
		{
			OverrideNoMatches (gtype, NoMatchesVMCallback);
		}

		static void OverrideNoMatches (GLib.GType gtype, NoMatchesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("no_matches"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NoMatchesNativeDelegate (IntPtr inst);

		static void NoMatches_cb (IntPtr inst)
		{
			try {
				EntryCompletion __obj = GLib.Object.GetObject (inst, false) as EntryCompletion;
				__obj.OnNoMatches ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.EntryCompletion), ConnectionMethod="OverrideNoMatches")]
		protected virtual void OnNoMatches ()
		{
			InternalNoMatches ();
		}

		private void InternalNoMatches ()
		{
			NoMatchesNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("no_matches"));
				unmanaged = (NoMatchesNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NoMatchesNativeDelegate));
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
						new GLib.AbiField("match_selected"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // match_selected
							, null
							, "action_activated"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("action_activated"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // action_activated
							, "match_selected"
							, "insert_prefix"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("insert_prefix"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // insert_prefix
							, "action_activated"
							, "cursor_on_match"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("cursor_on_match"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // cursor_on_match
							, "insert_prefix"
							, "no_matches"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("no_matches"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // no_matches
							, "cursor_on_match"
							, "_gtk_reserved0"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved0"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved0
							, "no_matches"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "_gtk_reserved0"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
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
		static extern void gtk_entry_completion_complete(IntPtr raw);

		public void Complete() {
			gtk_entry_completion_complete(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_compute_prefix(IntPtr raw, IntPtr key);

		public string ComputePrefix(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = gtk_entry_completion_compute_prefix(Handle, native_key);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_delete_action(IntPtr raw, int index_);

		public void DeleteAction(int index_) {
			gtk_entry_completion_delete_action(Handle, index_);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_get_completion_prefix(IntPtr raw);

		public string CompletionPrefix { 
			get {
				IntPtr raw_ret = gtk_entry_completion_get_completion_prefix(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_get_entry(IntPtr raw);

		public Gtk.Widget Entry { 
			get {
				IntPtr raw_ret = gtk_entry_completion_get_entry(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_entry_completion_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_entry_completion_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_insert_action_markup(IntPtr raw, int index_, IntPtr markup);

		public void InsertActionMarkup(int index_, string markup) {
			IntPtr native_markup = GLib.Marshaller.StringToPtrGStrdup (markup);
			gtk_entry_completion_insert_action_markup(Handle, index_, native_markup);
			GLib.Marshaller.Free (native_markup);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_insert_action_text(IntPtr raw, int index_, IntPtr text);

		public void InsertActionText(int index_, string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			gtk_entry_completion_insert_action_text(Handle, index_, native_text);
			GLib.Marshaller.Free (native_text);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_insert_prefix(IntPtr raw);

		public void InsertPrefix() {
			gtk_entry_completion_insert_prefix(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_entry_completion_set_match_func(IntPtr raw, GtkSharp.EntryCompletionMatchFuncNative func, IntPtr func_data, GLib.DestroyNotify func_notify);

		public Gtk.EntryCompletionMatchFunc MatchFunc { 
			set {
				GtkSharp.EntryCompletionMatchFuncWrapper value_wrapper = new GtkSharp.EntryCompletionMatchFuncWrapper (value);
				IntPtr func_data;
				GLib.DestroyNotify func_notify;
				if (value == null) {
					func_data = IntPtr.Zero;
					func_notify = null;
				} else {
					func_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					func_notify = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_entry_completion_set_match_func(Handle, value_wrapper.NativeDelegate, func_data, func_notify);
			}
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
