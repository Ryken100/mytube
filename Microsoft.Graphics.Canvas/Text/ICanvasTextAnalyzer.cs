using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A5 RID: 165
	[Version(167772160U)]
	[Guid(1117320145U, 25691, 16611, 185, 27, 129, 152, 109, 118, 127, 192)]
	[ExclusiveTo(typeof(CanvasTextAnalyzer))]
	internal interface ICanvasTextAnalyzer : IClosable
	{
		// Token: 0x060004C3 RID: 1219
		[Overload("GetFontsUsingSystemFontSet")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat);

		// Token: 0x060004C4 RID: 1220
		[Overload("GetFonts")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat, [In] CanvasFontSet fontSet);

		// Token: 0x060004C5 RID: 1221
		[Overload("GetBidi")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi();

		// Token: 0x060004C6 RID: 1222
		[Overload("GetBidiWithLocale")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi([In] string locale);

		// Token: 0x060004C7 RID: 1223
		[Overload("GetBreakpoints")]
		CanvasAnalyzedBreakpoint[] GetBreakpoints();

		// Token: 0x060004C8 RID: 1224
		[Overload("GetBreakpointsWithLocale")]
		CanvasAnalyzedBreakpoint[] GetBreakpoints([In] string locale);

		// Token: 0x060004C9 RID: 1225
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasNumberSubstitution>> GetNumberSubstitutions();

		// Token: 0x060004CA RID: 1226
		[Overload("GetScript")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript();

		// Token: 0x060004CB RID: 1227
		[Overload("GetScriptWithLocale")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript([In] string locale);

		// Token: 0x060004CC RID: 1228
		[Overload("GetGlyphOrientations")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations();

		// Token: 0x060004CD RID: 1229
		[Overload("GetGlyphOrientationsWithLocale")]
		IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations([In] string locale);

		// Token: 0x060004CE RID: 1230
		CanvasScriptProperties GetScriptProperties([In] CanvasAnalyzedScript analyzedScript);

		// Token: 0x060004CF RID: 1231
		[Overload("GetGlyphs")]
		CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script);

		// Token: 0x060004D0 RID: 1232
		[Overload("GetGlyphsWithAllOptions")]
		CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script, [In] string locale, [In] CanvasNumberSubstitution numberSubstitution, [In] IVectorView<IKeyValuePair<CanvasCharacterRange, CanvasTypography>> typographyRanges, out int[] clusterMapIndicesElements, out bool[] isShapedAloneGlyphsElements, out CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004D1 RID: 1233
		CanvasJustificationOpportunity[] GetJustificationOpportunities([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004D2 RID: 1234
		CanvasGlyph[] ApplyJustificationOpportunities([In] float lineWidth, [In] CanvasJustificationOpportunity[] justificationOpportunitiesElements, [In] CanvasGlyph[] sourceGlyphsElements);

		// Token: 0x060004D3 RID: 1235
		[Overload("AddGlyphsAfterJustification")]
		CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		// Token: 0x060004D4 RID: 1236
		[Overload("AddGlyphsAfterJustificationWithClusterMap")]
		[DefaultOverload]
		CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements, out int[] outputClusterMapIndicesElements);
	}
}
