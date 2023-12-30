using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000093 RID: 147
	[Version(167772160U)]
	[Static(typeof(ICanvasFontSetStatics), 167772160U)]
	[Activatable(typeof(ICanvasFontSetFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasFontSet : ICanvasFontSet, IClosable
	{
		// Token: 0x060004A9 RID: 1193
		public extern CanvasFontSet([In] Uri uri);

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060004AA RID: 1194
		public extern IVectorView<CanvasFontFace> Fonts { get; }

		// Token: 0x060004AB RID: 1195
		public extern bool TryFindFontFace([In] CanvasFontFace fontFace, out int index);

		// Token: 0x060004AC RID: 1196
		[Overload("GetMatchingFontsFromProperties")]
		public extern CanvasFontSet GetMatchingFonts([In] CanvasFontProperty[] propertyElements);

		// Token: 0x060004AD RID: 1197
		[Overload("GetMatchingFontsFromWwsFamily")]
		public extern CanvasFontSet GetMatchingFonts([In] string familyName, [In] FontWeight weight, [In] FontStretch stretch, [In] FontStyle style);

		// Token: 0x060004AE RID: 1198
		public extern uint CountFontsMatchingProperty([In] CanvasFontProperty property);

		// Token: 0x060004AF RID: 1199
		[Overload("GetPropertyValuesFromIndex")]
		[DefaultOverload]
		public extern IMapView<string, string> GetPropertyValues([In] uint fontIndex, [In] CanvasFontPropertyIdentifier propertyIdentifier);

		// Token: 0x060004B0 RID: 1200
		[Overload("GetPropertyValuesFromIdentifier")]
		public extern CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier, [In] string preferredLocaleNames);

		// Token: 0x060004B1 RID: 1201
		[Overload("GetPropertyValues")]
		public extern CanvasFontProperty[] GetPropertyValues([In] CanvasFontPropertyIdentifier propertyIdentifier);

		// Token: 0x060004B2 RID: 1202
		public extern void Close();

		// Token: 0x060004B3 RID: 1203
		public static extern CanvasFontSet GetSystemFontSet();
	}
}
