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
	[Windows.Foundation.Metadata.Guid(1369035049u, 20217, 19950, 183, 76, 77, 201, 16, 32, 26, 127)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasFontFace))]
	internal interface ICanvasFontFace : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetRecommendedRenderingMode")]
		CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetRecommendedRenderingModeWithAllOptions")]
		CanvasTextRenderingMode GetRecommendedRenderingMode([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextGridFit GetRecommendedGridFit([In] float fontSize, [In] float dpi, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasTextRenderingParameters renderingParameters, [In] Matrix3x2 transform, [In] bool isSideways, [In] CanvasAntialiasing outlineThreshold);

		Rect GlyphBox
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Vector2 SubscriptPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Size SubscriptSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Vector2 SuperscriptPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Size SuperscriptSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool HasTypographicMetrics
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float Ascent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float Descent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float LineGap
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float CapHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float LowercaseLetterHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float UnderlinePosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float UnderlineThickness
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float StrikethroughPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float StrikethroughThickness
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float CaretSlopeRise
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float CaretSlopeRun
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float CaretOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasUnicodeRange[] UnicodeRanges
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool IsMonospaced
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int[] GetVerticalGlyphVariants([In] int[] inputElements);

		bool HasVerticalGlyphVariants
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasFontFileFormatType FileFormatType
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasFontSimulations Simulations
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool IsSymbolFont
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		uint GlyphCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int[] GetGlyphIndices([In] uint[] inputElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGlyphMetrics[] GetGlyphMetrics([In] int[] inputElements, [In] bool isSideways);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGlyphMetrics[] GetGdiCompatibleGlyphMetrics([In] float fontSize, [In] float dpi, [In] Matrix3x2 transform, [In] bool useGdiNatural, [In] int[] inputElements, [In] bool isSideways);

		FontWeight Weight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		FontStretch Stretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		FontStyle Style
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		IReadOnlyDictionary<string, string> FamilyNames
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		IReadOnlyDictionary<string, string> FaceNames
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IReadOnlyDictionary<string, string> GetInformationalStrings([In] CanvasFontInformation fontInformation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool HasCharacter([In] uint unicodeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphRunBounds")]
		Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetGlyphRunBoundsWithMeasuringMode")]
		Rect GetGlyphRunBounds([In] CanvasDrawingSession drawingSession, [In] Vector2 point, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode);

		byte[] Panose
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSupportedTypographicFeatureNames")]
		CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSupportedTypographicFeatureNamesWithLocale")]
		CanvasTypographyFeatureName[] GetSupportedTypographicFeatureNames([In] CanvasAnalyzedScript script, [In] string locale);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetTypographicFeatureGlyphSupport")]
		bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetTypographicFeatureGlyphSupportWithLocale")]
		bool[] GetTypographicFeatureGlyphSupport([In] CanvasAnalyzedScript script, [In] CanvasTypographyFeatureName typographicFeatureName, [In] CanvasGlyph[] glyphsElements, [In] string locale);
	}
}
