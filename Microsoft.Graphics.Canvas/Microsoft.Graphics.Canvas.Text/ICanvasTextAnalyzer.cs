using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1117320145u, 25691, 16611, 185, 27, 129, 152, 109, 118, 127, 192)]
	[ExclusiveTo(typeof(CanvasTextAnalyzer))]
	internal interface ICanvasTextAnalyzer : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetFontsUsingSystemFontSet")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetFonts")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat, [In] CanvasFontSet fontSet);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBidi")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBidiWithLocale")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBreakpoints")]
		CanvasAnalyzedBreakpoint[] GetBreakpoints();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBreakpointsWithLocale")]
		CanvasAnalyzedBreakpoint[] GetBreakpoints([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasNumberSubstitution>> GetNumberSubstitutions();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetScript")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetScriptWithLocale")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphOrientations")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphOrientationsWithLocale")]
		IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasScriptProperties GetScriptProperties([In] CanvasAnalyzedScript analyzedScript);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphs")]
		CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphsWithAllOptions")]
		CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script, [In] string locale, [In] CanvasNumberSubstitution numberSubstitution, [In] IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasTypography>> typographyRanges, out int[] clusterMapIndicesElements, out bool[] isShapedAloneGlyphsElements, out CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasJustificationOpportunity[] GetJustificationOpportunities([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGlyph[] ApplyJustificationOpportunities([In] float lineWidth, [In] CanvasJustificationOpportunity[] justificationOpportunitiesElements, [In] CanvasGlyph[] sourceGlyphsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddGlyphsAfterJustification")]
		CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddGlyphsAfterJustificationWithClusterMap")]
		[DefaultOverload]
		CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements, out int[] outputClusterMapIndicesElements);
	}
}
