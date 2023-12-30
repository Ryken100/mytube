using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000092 RID: 146
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Version(167772160U)]
	[Guid(173800338U, 7996, 17823, 157, 126, 166, 40, 157, 208, 147, 192)]
	internal interface ICanvasFontSet : IClosable
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060004A1 RID: 1185
		IVectorView<CanvasFontFace> Fonts { get; }

		// Token: 0x060004A2 RID: 1186
		bool TryFindFontFace([In] CanvasFontFace fontFace, out int index);

		// Token: 0x060004A3 RID: 1187
		[Overload("GetMatchingFontsFromProperties")]
		CanvasFontSet GetMatchingFonts([In] CanvasFontProperty[] propertyElements);

		// Token: 0x060004A4 RID: 1188
		[Overload("GetMatchingFontsFromWwsFamily")]
		CanvasFontSet GetMatchingFonts([In] string familyName, [In] FontWeight weight, [In] FontStretch stretch, [In] FontStyle style);

		// Token: 0x060004A5 RID: 1189
		uint CountFontsMatchingProperty([In] CanvasFontProperty property);

		// Token: 0x060004A6 RID: 1190
		[DefaultOverload]
		[Overload("GetPropertyValuesFromIndex")]
		IMapView<string, string> GetPropertyValues([In] uint fontIndex, [In] CanvasFontPropertyIdentifier propertyIdentifier);

		// Token: 0x060004A7 RID: 1191
		[Overload("GetPropertyValuesFromIdentifier")]
		CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier, [In] string preferredLocaleNames);

		// Token: 0x060004A8 RID: 1192
		[Overload("GetPropertyValues")]
		CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier);
	}
}
