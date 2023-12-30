using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A6 RID: 166
	[ExclusiveTo(typeof(CanvasTextAnalyzer))]
	[Guid(1377715007U, 63128, 17600, 141, 127, 254, 55, 79, 229, 57, 225)]
	[Version(167772160U)]
	internal interface ICanvasTextAnalyzerFactory
	{
		// Token: 0x060004D5 RID: 1237
		CanvasTextAnalyzer Create([In] string text, [In] CanvasTextDirection textDirection);

		// Token: 0x060004D6 RID: 1238
		CanvasTextAnalyzer CreateWithNumberSubstitutionAndVerticalGlyphOrientationAndBidiLevel([In] string text, [In] CanvasTextDirection textDirection, [In] CanvasNumberSubstitution numberSubstitution, [In] CanvasVerticalGlyphOrientation verticalGlyphOrientation, [In] uint bidiLevel);

		// Token: 0x060004D7 RID: 1239
		CanvasTextAnalyzer CreateWithOptions([In] string text, [In] CanvasTextDirection textDirection, [In] ICanvasTextAnalyzerOptions options);
	}
}
