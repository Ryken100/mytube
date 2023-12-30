using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasFontFace : ICanvasFontFace, IDisposable
	{
		public extern float Ascent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float CapHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float CaretOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float CaretSlopeRise
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float CaretSlopeRun
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float Descent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern IReadOnlyDictionary<string, string> FaceNames
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern IReadOnlyDictionary<string, string> FamilyNames
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasFontFileFormatType FileFormatType
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect GlyphBox
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern uint GlyphCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool HasTypographicMetrics
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool HasVerticalGlyphVariants
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool IsMonospaced
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool IsSymbolFont
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float LineGap
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float LowercaseLetterHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern byte[] Panose
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasFontSimulations Simulations
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontStretch Stretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float StrikethroughPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float StrikethroughThickness
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontStyle Style
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Vector2 SubscriptPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Size SubscriptSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Vector2 SuperscriptPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Size SuperscriptSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float UnderlinePosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float UnderlineThickness
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasUnicodeRange[] UnicodeRanges
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontWeight Weight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetRecommendedRenderingMode")]
		public extern CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetRecommendedRenderingModeWithAllOptions")]
		public extern CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasTextGridFit GetRecommendedGridFit([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int[] GetVerticalGlyphVariants([In] int[] inputElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int[] GetGlyphIndices([In] uint[] inputElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasGlyphMetrics[] GetGlyphMetrics([In] int[] inputElements, [In] bool isSideways);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasGlyphMetrics[] GetGdiCompatibleGlyphMetrics([In] float fontSize, [In] float dpi, [In] Matrix3x2 transform, [In] bool useGdiNatural, [In] int[] inputElements, [In] bool isSideways);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IReadOnlyDictionary<string, string> GetInformationalStrings([In] CanvasFontInformation fontInformation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern bool HasCharacter([In] uint unicodeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphRunBounds")]
		public extern Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphRunBoundsWithMeasuringMode")]
		public extern Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSupportedTypographicFeatureNames")]
		public extern CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSupportedTypographicFeatureNamesWithLocale")]
		public extern CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script, [In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetTypographicFeatureGlyphSupport")]
		public extern bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetTypographicFeatureGlyphSupportWithLocale")]
		public extern bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements, [In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
