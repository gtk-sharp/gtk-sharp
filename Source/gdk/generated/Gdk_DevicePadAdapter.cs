// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DevicePadAdapter : GLib.GInterfaceAdapter, Gdk.IDevicePad {

		[StructLayout (LayoutKind.Sequential)]
		struct GdkDevicePadInterface {
			public GetNGroupsNativeDelegate GetNGroups;
			public GetGroupNModesNativeDelegate GetGroupNModes;
			public GetNFeaturesNativeDelegate GetNFeatures;
			public GetFeatureGroupNativeDelegate GetFeatureGroup;
		}

		static GdkDevicePadInterface iface;

		static DevicePadAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (DevicePadAdapter));
			iface.GetNGroups = new GetNGroupsNativeDelegate (GetNGroups_cb);
			iface.GetGroupNModes = new GetGroupNModesNativeDelegate (GetGroupNModes_cb);
			iface.GetNFeatures = new GetNFeaturesNativeDelegate (GetNFeatures_cb);
			iface.GetFeatureGroup = new GetFeatureGroupNativeDelegate (GetFeatureGroup_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNGroupsNativeDelegate (IntPtr inst);

		static int GetNGroups_cb (IntPtr inst)
		{
			try {
				IDevicePadImplementor __obj = GLib.Object.GetObject (inst, false) as IDevicePadImplementor;
				int __result;
				__result = __obj.NGroups;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetGroupNModesNativeDelegate (IntPtr inst, int group);

		static int GetGroupNModes_cb (IntPtr inst, int group)
		{
			try {
				IDevicePadImplementor __obj = GLib.Object.GetObject (inst, false) as IDevicePadImplementor;
				int __result;
				__result = __obj.GetGroupNModes (group);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNFeaturesNativeDelegate (IntPtr inst, int feature);

		static int GetNFeatures_cb (IntPtr inst, int feature)
		{
			try {
				IDevicePadImplementor __obj = GLib.Object.GetObject (inst, false) as IDevicePadImplementor;
				int __result;
				__result = __obj.GetNFeatures ((Gdk.DevicePadFeature) feature);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetFeatureGroupNativeDelegate (IntPtr inst, int feature, int idx);

		static int GetFeatureGroup_cb (IntPtr inst, int feature, int idx)
		{
			try {
				IDevicePadImplementor __obj = GLib.Object.GetObject (inst, false) as IDevicePadImplementor;
				int __result;
				__result = __obj.GetFeatureGroup ((Gdk.DevicePadFeature) feature, idx);
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
			GdkDevicePadInterface native_iface = (GdkDevicePadInterface) Marshal.PtrToStructure (ifaceptr, typeof (GdkDevicePadInterface));
			native_iface.GetNGroups = iface.GetNGroups;
			native_iface.GetGroupNModes = iface.GetGroupNModes;
			native_iface.GetNFeatures = iface.GetNFeatures;
			native_iface.GetFeatureGroup = iface.GetFeatureGroup;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public DevicePadAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public DevicePadAdapter (IDevicePadImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public DevicePadAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_pad_get_type();

		private static GLib.GType _gtype = new GLib.GType (gdk_device_pad_get_type ());

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

		public static IDevicePad GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IDevicePad GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IDevicePadImplementor)
				return new DevicePadAdapter (obj as IDevicePadImplementor);
			else if (obj as IDevicePad == null)
				return new DevicePadAdapter (obj.Handle);
			else
				return obj as IDevicePad;
		}

		public IDevicePadImplementor Implementor {
			get {
				return implementor as IDevicePadImplementor;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_pad_get_feature_group(IntPtr raw, int feature, int feature_idx);

		public int GetFeatureGroup(Gdk.DevicePadFeature feature, int feature_idx) {
			int raw_ret = gdk_device_pad_get_feature_group(Handle, (int) feature, feature_idx);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_pad_get_group_n_modes(IntPtr raw, int group_idx);

		public int GetGroupNModes(int group_idx) {
			int raw_ret = gdk_device_pad_get_group_n_modes(Handle, group_idx);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_pad_get_n_features(IntPtr raw, int feature);

		public int GetNFeatures(Gdk.DevicePadFeature feature) {
			int raw_ret = gdk_device_pad_get_n_features(Handle, (int) feature);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_pad_get_n_groups(IntPtr raw);

		public int NGroups { 
			get {
				int raw_ret = gdk_device_pad_get_n_groups(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
