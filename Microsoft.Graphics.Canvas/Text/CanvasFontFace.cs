using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000054 RID: 84
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasFontFace : ICanvasFontFace, IClosable
	{
		// Token: 0x06000266 RID: 614
		[Overload("GetRecommendedRenderingMode")]
		public extern CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters);

		// Token: 0x06000267 RID: 615
		[Overload("GetRecommendedRenderingModeWithAllOptions")]
		public extern CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		// Token: 0x06000268 RID: 616
		public extern CanvasTextGridFit GetRecommendedGridFit([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000269 RID: 617
		public extern Rect GlyphBox { get; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600026A RID: 618
		public extern Vector2 SubscriptPosition { get; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600026B RID: 619
		public extern Size SubscriptSize { get; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600026C RID: 620
		public extern Vector2 SuperscriptPosition { get; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600026D RID: 621
		public extern Size SuperscriptSize { get; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600026E RID: 622
		public extern bool HasTypographicMetrics { get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600026F RID: 623
		public extern float Ascent { get; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000270 RID: 624
		public extern float Descent { get; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000271 RID: 625
		public extern float LineGap { get; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000272 RID: 626
		public extern float CapHeight { get; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000273 RID: 627
		public extern float LowercaseLetterHeight { get; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000274 RID: 628
		public extern float UnderlinePosition { get; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000275 RID: 629
		public extern float UnderlineThickness { get; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000276 RID: 630
		public extern float StrikethroughPosition { get; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000277 RID: 631
		public extern float StrikethroughThickness { get; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000278 RID: 632
		public extern float CaretSlopeRise { get; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000279 RID: 633
		public extern float CaretSlopeRun { get; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600027A RID: 634
		public extern float CaretOffset { get; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600027B RID: 635
		public extern CanvasUnicodeRange[] UnicodeRanges { get; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600027C RID: 636
		public extern bool IsMonospaced { get; }

		// Token: 0x0600027D RID: 637
		public extern int[] GetVerticalGlyphVariants([In] int[] inputElements);

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600027E RID: 638
		public extern bool HasVerticalGlyphVariants { get; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600027F RID: 639
		public extern CanvasFontFileFormatType FileFormatType { get; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000280 RID: 640
		public extern CanvasFontSimulations Simulations { get; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000281 RID: 641
		public extern bool IsSymbolFont { get; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000282 RID: 642
		public extern uint GlyphCount { get; }

		// Token: 0x06000283 RID: 643
		public extern int[] GetGlyphIndices([In] uint[] inputElements);

		// Token: 0x06000284 RID: 644
		public extern CanvasGlyphMetrics[] GetGlyphMetrics([In] int[] inputElements, [In] bool isSideways);

		// Token: 0x06000285 RID: 645
		public extern CanvasGlyphMetrics[] GetGdiCompatibleGlyphMetrics([In] float fontSize, [In] float dpi, [In] Matrix3x2 transform, [In] bool useGdiNatural, [In] int[] inputElements, [In] bool isSideways);

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000286 RID: 646
		public extern FontWeight Weight { get; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000287 RID: 647
		public extern FontStretch Stretch { get; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000288 RID: 648
		public extern FontStyle Style { get; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000289 RID: 649
		public extern IMapView<string, string> FamilyNames { get; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600028A RID: 650
		public extern IMapView<string, string> FaceNames { get; }

		// Token: 0x0600028B RID: 651
		public extern IMapView<string, string> GetInformationalStrings([In] CanvasFontInformation fontInformation);

		// Token: 0x0600028C RID: 652
		public extern bool HasCharacter([In] uint unicodeValue);

		// Token: 0x0600028D RID: 653
		[Overload("GetGlyphRunBounds")]
		public extern Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel);

		// Token: 0x0600028E RID: 654
		[Overload("GetGlyphRunBoundsWithMeasuringMode")]
		public extern Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode);

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600028F RID: 655
		public extern byte[] Panose { get; }

		// Token: 0x06000290 RID: 656
		[Overload("GetSupportedTypographicFeatureNames")]
		public extern CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script);

		// Token: 0x06000291 RID: 657
		[Overload("GetSupportedTypographicFeatureNamesWithLocale")]
		public extern CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script, [In] string locale);

		// Token: 0x06000292 RID: 658
		[Overload("GetTypographicFeatureGlyphSupport")]
		public extern bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements);

		// Token: 0x06000293 RID: 659
		[Overload("GetTypographicFeatureGlyphSupportWithLocale")]
		public extern bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements, [In] string locale);

		// Token: 0x06000294 RID: 660
		public extern void Close();
	}
}
