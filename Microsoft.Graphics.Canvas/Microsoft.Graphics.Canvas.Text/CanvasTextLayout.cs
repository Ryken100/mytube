using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Brushes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(ICanvasTextLayoutStatics), 167772160u)]
	[Activatable(typeof(ICanvasTextLayoutFactory), 167772160u)]
	public sealed class CanvasTextLayout : ICanvasTextLayout, IDisposable
	{
		public extern CanvasWordWrapping WordWrapping
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasVerticalGlyphOrientation VerticalGlyphOrientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasVerticalAlignment VerticalAlignment
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasTrimmingSign TrimmingSign
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasTextTrimmingGranularity TrimmingGranularity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern int TrimmingDelimiterCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern string TrimmingDelimiter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Size RequestedSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasDrawTextOptions Options
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasOpticalAlignment OpticalAlignment
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasLineSpacingMode LineSpacingMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern float LineSpacingBaseline
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern float LineSpacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern bool LastLineWrapping
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern float IncrementalTabStop
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasHorizontalAlignment HorizontalAlignment
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasTextDirection Direction
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern ICanvasTextInlineObject CustomTrimmingSign
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasClusterMetrics[] ClusterMetrics
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern string DefaultFontFamily
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float DefaultFontSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontStretch DefaultFontStretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontStyle DefaultFontStyle
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern FontWeight DefaultFontWeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern string DefaultLocaleName
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect DrawBounds
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect LayoutBounds
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect LayoutBoundsIncludingTrailingWhitespace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern int LineCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasLineMetrics[] LineMetrics
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern int MaximumBidiReorderingDepth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int[] GetFormatChangeIndices();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetMinimumLineLength();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasBrush GetBrush([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern object GetCustomBrush([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern string GetFontFamily([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetFontSize([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern FontStretch GetFontStretch([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern FontStyle GetFontStyle([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern FontWeight GetFontWeight([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern string GetLocaleName([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern bool GetStrikethrough([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern bool GetUnderline([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasTextInlineObject GetInlineObject([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetColor([In] int characterIndex, [In] int characterCount, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetBrush([In] int characterIndex, [In] int characterCount, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetCustomBrush([In] int characterIndex, [In] int characterCount, [In] object brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFontFamily([In] int characterIndex, [In] int characterCount, [In] string fontFamily);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFontSize([In] int characterIndex, [In] int characterCount, [In] float fontSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFontStretch([In] int characterIndex, [In] int characterCount, [In] FontStretch fontStretch);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFontStyle([In] int characterIndex, [In] int characterCount, [In] FontStyle fontStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFontWeight([In] int characterIndex, [In] int characterCount, [In] FontWeight fontWeight);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetLocaleName([In] int characterIndex, [In] int characterCount, [In] string name);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetStrikethrough([In] int characterIndex, [In] int characterCount, [In] bool hasStrikethrough);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetUnderline([In] int characterIndex, [In] int characterCount, [In] bool hasUnderline);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetInlineObject([In] int characterIndex, [In] int characterCount, [In] ICanvasTextInlineObject inlineObject);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToTextRenderer")]
		public extern void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] Vector2 position);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToTextRendererWithCoords")]
		public extern void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetTypography([In] int characterIndex, [In] int characterCount, [In] CanvasTypography typography);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasTypography GetTypography([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("HitTest")]
		public extern bool HitTest([In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("HitTestWithCoords")]
		[DefaultOverload]
		public extern bool HitTest([In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("HitTestWithDescription")]
		public extern bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("HitTestWithDescriptionAndCoords")]
		public extern bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("HitTestWithDescriptionAndTrailingSide")]
		public extern bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("HitTestWithDescriptionAndCoordsAndTrailingSide")]
		public extern bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetCaretPosition")]
		public extern Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetCaretPositionWithDescription")]
		[DefaultOverload]
		public extern Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter, out CanvasTextLayoutRegion textLayoutRegion);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetCharacterRegions")]
		[DefaultOverload]
		public extern CanvasTextLayoutRegion[] GetCharacterRegions([In] int characterIndex, [In] int characterCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern bool GetPairKerning([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetPairKerning([In] int characterIndex, [In] int characterCount, [In] bool hasPairKerning);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetLeadingCharacterSpacing([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetTrailingCharacterSpacing([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetMinimumCharacterAdvance([In] int characterIndex);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetCharacterSpacing([In] int characterIndex, [In] int characterCount, [In] float leadingSpacing, [In] float trailingSpacing, [In] float minimumAdvance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern Matrix3x2 GetGlyphOrientationTransform([In] CanvasGlyphOrientation glyphOrientation, [In] bool isSideways, [In] Vector2 position);
	}
}
