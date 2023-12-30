using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(173800338u, 7996, 17823, 157, 126, 166, 40, 157, 208, 147, 192)]
	internal interface ICanvasFontSet : IDisposable
	{
		IReadOnlyList<CanvasFontFace> Fonts
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool TryFindFontFace([In] CanvasFontFace fontFace, out int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetMatchingFontsFromProperties")]
		CanvasFontSet GetMatchingFonts([In] CanvasFontProperty[] propertyElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetMatchingFontsFromWwsFamily")]
		CanvasFontSet GetMatchingFonts([In] string familyName, [In] FontWeight weight, [In] FontStretch stretch, [In] FontStyle style);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint CountFontsMatchingProperty([In] CanvasFontProperty property);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("GetPropertyValuesFromIndex")]
		IReadOnlyDictionary<string, string> GetPropertyValues([In] uint fontIndex, [In] CanvasFontPropertyIdentifier propertyIdentifier);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPropertyValuesFromIdentifier")]
		CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier, [In] string preferredLocaleNames);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPropertyValues")]
		CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier);
	}
}
