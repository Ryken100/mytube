using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Activatable(typeof(ICanvasTextAnalyzerFactory), 167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasTextAnalyzer : ICanvasTextAnalyzer, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetFontsUsingSystemFontSet")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetFonts")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasScaledFont>> GetFonts([In] CanvasTextFormat textFormat, [In] CanvasFontSet fontSet);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBidi")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBidiWithLocale")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedBidi>> GetBidi([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBreakpoints")]
		public extern CanvasAnalyzedBreakpoint[] GetBreakpoints();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBreakpointsWithLocale")]
		public extern CanvasAnalyzedBreakpoint[] GetBreakpoints([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasNumberSubstitution>> GetNumberSubstitutions();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetScript")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetScriptWithLocale")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedScript>> GetScript([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphOrientations")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphOrientationsWithLocale")]
		public extern IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasAnalyzedGlyphOrientation>> GetGlyphOrientations([In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasScriptProperties GetScriptProperties([In] CanvasAnalyzedScript analyzedScript);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphs")]
		public extern CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphsWithAllOptions")]
		public extern CanvasGlyph[] GetGlyphs([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] bool isSideways, [In] bool isRightToLeft, [In] CanvasAnalyzedScript script, [In] string locale, [In] CanvasNumberSubstitution numberSubstitution, [In] IReadOnlyList<KeyValuePair<CanvasCharacterRange, CanvasTypography>> typographyRanges, out int[] clusterMapIndicesElements, out bool[] isShapedAloneGlyphsElements, out CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasJustificationOpportunity[] GetJustificationOpportunities([In] CanvasCharacterRange characterRange, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasGlyph[] ApplyJustificationOpportunities([In] float lineWidth, [In] CanvasJustificationOpportunity[] justificationOpportunitiesElements, [In] CanvasGlyph[] sourceGlyphsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddGlyphsAfterJustification")]
		public extern CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("AddGlyphsAfterJustificationWithClusterMap")]
		public extern CanvasGlyph[] AddGlyphsAfterJustification([In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasAnalyzedScript script, [In] int[] clusterMapIndicesElements, [In] CanvasGlyph[] originalGlyphsElements, [In] CanvasGlyph[] justifiedGlyphsElements, [In] CanvasGlyphShaping[] glyphShapingResultsElements, out int[] outputClusterMapIndicesElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
