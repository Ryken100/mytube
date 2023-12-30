using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A7 RID: 167
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(typeof(ICanvasTextAnalyzerFactory), 167772160U)]
	[Threading(3)]
	public sealed class CanvasTextAnalyzer : ICanvasTextAnalyzer, IClosable
	{
		// Token: 0x060004D8 RID: 1240
		public extern CanvasTextAnalyzer([In] string text, [In] CanvasTextDirection textDirection);

		// Token: 0x060004D9 RID: 1241
		public extern CanvasTextAnalyzer([In] string text, [In] CanvasTextDirection textDirection, [In] CanvasNumberSubstitution numberSubstitution, [In] CanvasVerticalGlyphOrientation verticalGlyphOrientation, [In] uint bidiLevel);

		// Token: 0x060004DA RID: 1242
		public extern CanvasTextAnalyzer([In] string text, [In] CanvasTextDirection textDirection, [In] ICanvasTextAnalyzerOptions options);

		// Token: 0x060004DB RID: 1243
		[Overload("GetFontsUsingSystemFontSet")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat);

		// Token: 0x060004DC RID: 1244
		[Overload("GetFonts")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat, [In] CanvasFontSet fontSet);

		// Token: 0x060004DD RID: 1245
		[Overload("GetBidi")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi();

		// Token: 0x060004DE RID: 1246
		[Overload("GetBidiWithLocale")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi([In] string locale);

		// Token: 0x060004DF RID: 1247
		[Overload("GetBreakpoints")]
		public extern CanvasAnalyzedBreakpoint[] GetBreakpoints();

		// Token: 0x060004E0 RID: 1248
		[Overload("GetBreakpointsWithLocale")]
		public extern CanvasAnalyzedBreakpoint[] GetBreakpoints([In] string locale);

		// Token: 0x060004E1 RID: 1249
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasNumberSubstitution>> GetNumberSubstitutions();

		// Token: 0x060004E2 RID: 1250
		[Overload("GetScript")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript();

		// Token: 0x060004E3 RID: 1251
		[Overload("GetScriptWithLocale")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript([In] string locale);

		// Token: 0x060004E4 RID: 1252
		[Overload("GetGlyphOrientations")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations();

		// Token: 0x060004E5 RID: 1253
		[Overload("GetGlyphOrientationsWithLocale")]
		public extern IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations([In] string locale);

		// Token: 0x060004E6 RID: 1254
		public extern CanvasScriptProperties GetScriptProperties([In] CanvasAnalyzedScript analyzedScript);

		// Token: 0x060004E7 RID: 1255
		[Overload("GetGlyphs")]
		public extern CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script);

		// Token: 0x060004E8 RID: 1256
		[Overload("GetGlyphsWithAllOptions")]
		public extern CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script, [In] string locale, [In] CanvasNumberSubstitution numberSubstitution, [In] IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasTypography>> typographyRanges, out int[] clusterMapIndicesElements, out bool[] isShapedAloneGlyphsElements, out CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004E9 RID: 1257
		public extern CanvasJustificationOpportunity[] GetJustificationOpportunities([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004EA RID: 1258
		public extern CanvasGlyph[] ApplyJustificationOpportunities([In] float lineWidth, [In] CanvasJustificationOpportunity[] justificationOpportunitiesElements, [In] CanvasGlyph[] sourceGlyphsElements);

		// Token: 0x060004EB RID: 1259
		[Overload("AddGlyphsAfterJustification")]
		public extern CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004EC RID: 1260
		[DefaultOverload]
		[Overload("AddGlyphsAfterJustificationWithClusterMap")]
		public extern CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements, out int[] outputClusterMapIndicesElements);

		// Token: 0x060004ED RID: 1261
		public extern void Close();
	}
}
