using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Static(typeof(ICanvasFontSetStatics), 167772160u)]
	[Activatable(typeof(ICanvasFontSetFactory), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasFontSet : ICanvasFontSet, IDisposable
	{
		public extern IReadOnlyList<CanvasFontFace> Fonts
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern bool TryFindFontFace([In] CanvasFontFace fontFace, out int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetMatchingFontsFromProperties")]
		public extern CanvasFontSet GetMatchingFonts([In] CanvasFontProperty[] propertyElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetMatchingFontsFromWwsFamily")]
		public extern CanvasFontSet GetMatchingFonts([In] string familyName, [In] FontWeight weight, [In] FontStretch stretch, [In] FontStyle style);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern uint CountFontsMatchingProperty([In] CanvasFontProperty property);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPropertyValuesFromIndex")]
		[DefaultOverload]
		public extern IReadOnlyDictionary<string, string> GetPropertyValues([In] uint fontIndex, [In] CanvasFontPropertyIdentifier propertyIdentifier);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPropertyValuesFromIdentifier")]
		public extern CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier, [In] string preferredLocaleNames);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPropertyValues")]
		public extern CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasFontSet GetSystemFontSet();
	}
}
