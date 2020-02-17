// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Hyperlink : GLib.Object, Atk.IAction {

		public Hyperlink (IntPtr raw) : base(raw) {}

		protected Hyperlink() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("selected-link")]
		public bool SelectedLink {
			get {
				GLib.Value val = GetProperty ("selected-link");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("number-of-anchors")]
		public int NumberOfAnchors {
			get {
				GLib.Value val = GetProperty ("number-of-anchors");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_end_index(IntPtr raw);

		[GLib.Property ("end-index")]
		public int EndIndex {
			get  {
				int raw_ret = atk_hyperlink_get_end_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_start_index(IntPtr raw);

		[GLib.Property ("start-index")]
		public int StartIndex {
			get  {
				int raw_ret = atk_hyperlink_get_start_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[GLib.Signal("link_activated")]
		public event System.EventHandler LinkActivated {
			add {
				this.AddSignalHandler ("link_activated", value);
			}
			remove {
				this.RemoveSignalHandler ("link_activated", value);
			}
		}

		static GetUriNativeDelegate GetUri_cb_delegate;
		static GetUriNativeDelegate GetUriVMCallback {
			get {
				if (GetUri_cb_delegate == null)
					GetUri_cb_delegate = new GetUriNativeDelegate (GetUri_cb);
				return GetUri_cb_delegate;
			}
		}

		static void OverrideGetUri (GLib.GType gtype)
		{
			OverrideGetUri (gtype, GetUriVMCallback);
		}

		static void OverrideGetUri (GLib.GType gtype, GetUriNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_uri"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetUriNativeDelegate (IntPtr inst, int i);

		static IntPtr GetUri_cb (IntPtr inst, int i)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				string __result;
				__result = __obj.OnGetUri (i);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetUri")]
		protected virtual string OnGetUri (int i)
		{
			return InternalGetUri (i);
		}

		private string InternalGetUri (int i)
		{
			GetUriNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_uri"));
				unmanaged = (GetUriNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetUriNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, i);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static GetObjectNativeDelegate GetObject_cb_delegate;
		static GetObjectNativeDelegate GetObjectVMCallback {
			get {
				if (GetObject_cb_delegate == null)
					GetObject_cb_delegate = new GetObjectNativeDelegate (GetObject_cb);
				return GetObject_cb_delegate;
			}
		}

		static void OverrideGetObject (GLib.GType gtype)
		{
			OverrideGetObject (gtype, GetObjectVMCallback);
		}

		static void OverrideGetObject (GLib.GType gtype, GetObjectNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_object"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetObjectNativeDelegate (IntPtr inst, int i);

		static IntPtr GetObject_cb (IntPtr inst, int i)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				Atk.Object __result;
				__result = __obj.OnGetObject (i);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetObject")]
		protected virtual Atk.Object OnGetObject (int i)
		{
			return InternalGetObject (i);
		}

		private Atk.Object InternalGetObject (int i)
		{
			GetObjectNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_object"));
				unmanaged = (GetObjectNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetObjectNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, i);
			return GLib.Object.GetObject(__result) as Atk.Object;
		}

		static GetEndIndexNativeDelegate GetEndIndex_cb_delegate;
		static GetEndIndexNativeDelegate GetEndIndexVMCallback {
			get {
				if (GetEndIndex_cb_delegate == null)
					GetEndIndex_cb_delegate = new GetEndIndexNativeDelegate (GetEndIndex_cb);
				return GetEndIndex_cb_delegate;
			}
		}

		static void OverrideGetEndIndex (GLib.GType gtype)
		{
			OverrideGetEndIndex (gtype, GetEndIndexVMCallback);
		}

		static void OverrideGetEndIndex (GLib.GType gtype, GetEndIndexNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_end_index"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetEndIndexNativeDelegate (IntPtr inst);

		static int GetEndIndex_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				int __result;
				__result = __obj.OnGetEndIndex ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetEndIndex")]
		protected virtual int OnGetEndIndex ()
		{
			return InternalGetEndIndex ();
		}

		private int InternalGetEndIndex ()
		{
			GetEndIndexNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_end_index"));
				unmanaged = (GetEndIndexNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetEndIndexNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static GetStartIndexNativeDelegate GetStartIndex_cb_delegate;
		static GetStartIndexNativeDelegate GetStartIndexVMCallback {
			get {
				if (GetStartIndex_cb_delegate == null)
					GetStartIndex_cb_delegate = new GetStartIndexNativeDelegate (GetStartIndex_cb);
				return GetStartIndex_cb_delegate;
			}
		}

		static void OverrideGetStartIndex (GLib.GType gtype)
		{
			OverrideGetStartIndex (gtype, GetStartIndexVMCallback);
		}

		static void OverrideGetStartIndex (GLib.GType gtype, GetStartIndexNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_start_index"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetStartIndexNativeDelegate (IntPtr inst);

		static int GetStartIndex_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				int __result;
				__result = __obj.OnGetStartIndex ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetStartIndex")]
		protected virtual int OnGetStartIndex ()
		{
			return InternalGetStartIndex ();
		}

		private int InternalGetStartIndex ()
		{
			GetStartIndexNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_start_index"));
				unmanaged = (GetStartIndexNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetStartIndexNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static IsValidNativeDelegate IsValid_cb_delegate;
		static IsValidNativeDelegate IsValidVMCallback {
			get {
				if (IsValid_cb_delegate == null)
					IsValid_cb_delegate = new IsValidNativeDelegate (IsValid_cb);
				return IsValid_cb_delegate;
			}
		}

		static void OverrideIsValid (GLib.GType gtype)
		{
			OverrideIsValid (gtype, IsValidVMCallback);
		}

		static void OverrideIsValid (GLib.GType gtype, IsValidNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("is_valid"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsValidNativeDelegate (IntPtr inst);

		static bool IsValid_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				bool __result;
				__result = __obj.OnIsValid ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideIsValid")]
		protected virtual bool OnIsValid ()
		{
			return InternalIsValid ();
		}

		private bool InternalIsValid ()
		{
			IsValidNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("is_valid"));
				unmanaged = (IsValidNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(IsValidNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static GetNAnchorsNativeDelegate GetNAnchors_cb_delegate;
		static GetNAnchorsNativeDelegate GetNAnchorsVMCallback {
			get {
				if (GetNAnchors_cb_delegate == null)
					GetNAnchors_cb_delegate = new GetNAnchorsNativeDelegate (GetNAnchors_cb);
				return GetNAnchors_cb_delegate;
			}
		}

		static void OverrideGetNAnchors (GLib.GType gtype)
		{
			OverrideGetNAnchors (gtype, GetNAnchorsVMCallback);
		}

		static void OverrideGetNAnchors (GLib.GType gtype, GetNAnchorsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_n_anchors"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNAnchorsNativeDelegate (IntPtr inst);

		static int GetNAnchors_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				int __result;
				__result = __obj.OnGetNAnchors ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetNAnchors")]
		protected virtual int OnGetNAnchors ()
		{
			return InternalGetNAnchors ();
		}

		private int InternalGetNAnchors ()
		{
			GetNAnchorsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_n_anchors"));
				unmanaged = (GetNAnchorsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetNAnchorsNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static LinkStateNativeDelegate LinkState_cb_delegate;
		static LinkStateNativeDelegate LinkStateVMCallback {
			get {
				if (LinkState_cb_delegate == null)
					LinkState_cb_delegate = new LinkStateNativeDelegate (LinkState_cb);
				return LinkState_cb_delegate;
			}
		}

		static void OverrideLinkState (GLib.GType gtype)
		{
			OverrideLinkState (gtype, LinkStateVMCallback);
		}

		static void OverrideLinkState (GLib.GType gtype, LinkStateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("link_state"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint LinkStateNativeDelegate (IntPtr inst);

		static uint LinkState_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				uint __result;
				__result = __obj.OnLinkState ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideLinkState")]
		protected virtual uint OnLinkState ()
		{
			return InternalLinkState ();
		}

		private uint InternalLinkState ()
		{
			LinkStateNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("link_state"));
				unmanaged = (LinkStateNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(LinkStateNativeDelegate));
			}
			if (unmanaged == null) return 0;

			uint __result = unmanaged (this.Handle);
			return __result;
		}

		static IsSelectedLinkNativeDelegate IsSelectedLink_cb_delegate;
		static IsSelectedLinkNativeDelegate IsSelectedLinkVMCallback {
			get {
				if (IsSelectedLink_cb_delegate == null)
					IsSelectedLink_cb_delegate = new IsSelectedLinkNativeDelegate (IsSelectedLink_cb);
				return IsSelectedLink_cb_delegate;
			}
		}

		static void OverrideIsSelectedLink (GLib.GType gtype)
		{
			OverrideIsSelectedLink (gtype, IsSelectedLinkVMCallback);
		}

		static void OverrideIsSelectedLink (GLib.GType gtype, IsSelectedLinkNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("is_selected_link"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsSelectedLinkNativeDelegate (IntPtr inst);

		static bool IsSelectedLink_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				bool __result;
				__result = __obj.OnIsSelectedLink ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideIsSelectedLink")]
		protected virtual bool OnIsSelectedLink ()
		{
			return InternalIsSelectedLink ();
		}

		private bool InternalIsSelectedLink ()
		{
			IsSelectedLinkNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("is_selected_link"));
				unmanaged = (IsSelectedLinkNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(IsSelectedLinkNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static LinkActivatedNativeDelegate LinkActivated_cb_delegate;
		static LinkActivatedNativeDelegate LinkActivatedVMCallback {
			get {
				if (LinkActivated_cb_delegate == null)
					LinkActivated_cb_delegate = new LinkActivatedNativeDelegate (LinkActivated_cb);
				return LinkActivated_cb_delegate;
			}
		}

		static void OverrideLinkActivated (GLib.GType gtype)
		{
			OverrideLinkActivated (gtype, LinkActivatedVMCallback);
		}

		static void OverrideLinkActivated (GLib.GType gtype, LinkActivatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("link_activated"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LinkActivatedNativeDelegate (IntPtr inst);

		static void LinkActivated_cb (IntPtr inst)
		{
			try {
				Hyperlink __obj = GLib.Object.GetObject (inst, false) as Hyperlink;
				__obj.OnLinkActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideLinkActivated")]
		protected virtual void OnLinkActivated ()
		{
			InternalLinkActivated ();
		}

		private void InternalLinkActivated ()
		{
			LinkActivatedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("link_activated"));
				unmanaged = (LinkActivatedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(LinkActivatedNativeDelegate));
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
						new GLib.AbiField("get_uri"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_uri
							, null
							, "get_object"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_object"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_object
							, "get_uri"
							, "get_end_index"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_end_index"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_end_index
							, "get_object"
							, "get_start_index"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_start_index"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_start_index
							, "get_end_index"
							, "is_valid"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("is_valid"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // is_valid
							, "get_start_index"
							, "get_n_anchors"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_n_anchors"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_n_anchors
							, "is_valid"
							, "link_state"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("link_state"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // link_state
							, "get_n_anchors"
							, "is_selected_link"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("is_selected_link"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // is_selected_link
							, "link_state"
							, "link_activated"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("link_activated"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // link_activated
							, "is_selected_link"
							, "pad1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pad1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pad1
							, "link_activated"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_n_anchors(IntPtr raw);

		public int NAnchors { 
			get {
				int raw_ret = atk_hyperlink_get_n_anchors(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_object(IntPtr raw, int i);

		public Atk.Object GetObject(int i) {
			IntPtr raw_ret = atk_hyperlink_get_object(Handle, i);
			Atk.Object ret = GLib.Object.GetObject(raw_ret) as Atk.Object;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_hyperlink_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_uri(IntPtr raw, int i);

		public string GetUri(int i) {
			IntPtr raw_ret = atk_hyperlink_get_uri(Handle, i);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_inline(IntPtr raw);

		public bool IsInline { 
			get {
				bool raw_ret = atk_hyperlink_is_inline(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_selected_link(IntPtr raw);

		[Obsolete]
		public bool IsSelectedLink { 
			get {
				bool raw_ret = atk_hyperlink_is_selected_link(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_valid(IntPtr raw);

		public bool IsValid { 
			get {
				bool raw_ret = atk_hyperlink_is_valid(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_action_do_action(IntPtr raw, int i);

		public bool DoAction(int i) {
			bool raw_ret = atk_action_do_action(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_description(IntPtr raw, int i);

		public string GetDescription(int i) {
			IntPtr raw_ret = atk_action_get_description(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_keybinding(IntPtr raw, int i);

		public string GetKeybinding(int i) {
			IntPtr raw_ret = atk_action_get_keybinding(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_localized_name(IntPtr raw, int i);

		public string GetLocalizedName(int i) {
			IntPtr raw_ret = atk_action_get_localized_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_action_get_n_actions(IntPtr raw);

		public int NActions { 
			get {
				int raw_ret = atk_action_get_n_actions(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_name(IntPtr raw, int i);

		public string GetName(int i) {
			IntPtr raw_ret = atk_action_get_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_action_set_description(IntPtr raw, int i, IntPtr desc);

		public bool SetDescription(int i, string desc) {
			IntPtr native_desc = GLib.Marshaller.StringToPtrGStrdup (desc);
			bool raw_ret = atk_action_set_description(Handle, i, native_desc);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_desc);
			return ret;
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
