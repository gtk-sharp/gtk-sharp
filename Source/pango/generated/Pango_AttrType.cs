// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.AttrTypeGType))]
	public enum AttrType {

		Invalid,
		Language,
		Family,
		Style,
		Weight,
		Variant,
		Stretch,
		Size,
		FontDesc,
		Foreground,
		Background,
		Underline,
		Strikethrough,
		Rise,
		Shape,
		Scale,
		Fallback,
		LetterSpacing,
		UnderlineColor,
		StrikethroughColor,
		AbsoluteSize,
		Gravity,
		GravityHint,
		FontFeatures,
		ForegroundAlpha,
		BackgroundAlpha,
	}

	internal class AttrTypeGType {
		[DllImport ("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_attr_type_get_type ());
			}
		}
	}
#endregion
}
