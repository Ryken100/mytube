using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000088 RID: 136
	[Guid(1369035049U, 20217, 19950, 183, 76, 77, 201, 16, 32, 26, 127)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasFontFace))]
	internal interface ICanvasFontFace : IClosable
	{
		// Token: 0x0600042A RID: 1066
		[Overload("GetRecommendedRenderingMode")]
		CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters);

		// Token: 0x0600042B RID: 1067
		[Overload("GetRecommendedRenderingModeWithAllOptions")]
		CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		// Token: 0x0600042C RID: 1068
		CanvasTextGridFit GetRecommendedGridFit([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600042D RID: 1069
		Rect GlyphBox { get; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600042E RID: 1070
		Vector2 SubscriptPosition { get; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600042F RID: 1071
		Size SubscriptSize { get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000430 RID: 1072
		Vector2 SuperscriptPosition { get; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000431 RID: 1073
		Size SuperscriptSize { get; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000432 RID: 1074
		bool HasTypographicMetrics { get; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000433 RID: 1075
		float Ascent { get; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000434 RID: 1076
		float Descent { get; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000435 RID: 1077
		float LineGap { get; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000436 RID: 1078
		float CapHeight { get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000437 RID: 1079
		float LowercaseLetterHeight { get; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000438 RID: 1080
		float UnderlinePosition { get; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000439 RID: 1081
		float UnderlineThickness { get; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600043A RID: 1082
		float StrikethroughPosition { get; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600043B RID: 1083
		float StrikethroughThickness { get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600043C RID: 1084
		float CaretSlopeRise { get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600043D RID: 1085
		float CaretSlopeRun { get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600043E RID: 1086
		float CaretOffset { get; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600043F RID: 1087
		CanvasUnicodeRange[] UnicodeRanges { get; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000440 RID: 1088
		bool IsMonospaced { get; }

		// Token: 0x06000441 RID: 1089
		int[] GetVerticalGlyphVariants([In] int[] inputElements);

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000442 RID: 1090
		bool HasVerticalGlyphVariants { get; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000443 RID: 1091
		CanvasFontFileFormatType FileFormatType { get; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000444 RID: 1092
		CanvasFontSimulations Simulations { get; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000445 RID: 1093
		bool IsSymbolFont { get; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000446 RID: 1094
		uint GlyphCount { get; }

		// Token: 0x06000447 RID: 1095
		int[] GetGlyphIndices([In] uint[] inputElements);

		// Token: 0x06000448 RID: 1096
		CanvasGlyphMetrics[] GetGlyphMetrics([In] int[] inputElements, [In] bool isSideways);

		// Token: 0x06000449 RID: 1097
		CanvasGlyphMetrics[] GetGdiCompatibleGlyphMetrics([In] float fontSize, [In] float dpi, [In] Matrix3x2 transform, [In] bool useGdiNatural, [In] int[] inputElements, [In] bool isSideways);

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600044A RID: 1098
		FontWeight Weight { get; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600044B RID: 1099
		FontStretch Stretch { get; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600044C RID: 1100
		FontStyle Style { get; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600044D RID: 1101
		IMapView<string, string> FamilyNames { get; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600044E RID: 1102
		IMapView<string, string> FaceNames { get; }

		// Token: 0x0600044F RID: 1103
		IMapView<string, string> GetInformationalStrings([In] CanvasFontInformation fontInformation);

		// Token: 0x06000450 RID: 1104
		bool HasCharacter([In] uint unicodeValue);

		// Token: 0x06000451 RID: 1105
		[Overload("GetGlyphRunBounds")]
		Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel);

		// Token: 0x06000452 RID: 1106
		[Overload("GetGlyphRunBoundsWithMeasuringMode")]
		Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode);

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000453 RID: 1107
		byte[] Panose { get; }

		// Token: 0x06000454 RID: 1108
		[Overload("GetSupportedTypographicFeatureNames")]
		CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script);

		// Token: 0x06000455 RID: 1109
		[Overload("GetSupportedTypographicFeatureNamesWithLocale")]
		CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script, [In] string locale);

		// Token: 0x06000456 RID: 1110
		[Overload("GetTypographicFeatureGlyphSupport")]
		bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements);

		// Token: 0x06000457 RID: 1111
		[Overload("GetTypographicFeatureGlyphSupportWithLocale")]
		bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements, [In] string locale);
	}
}
