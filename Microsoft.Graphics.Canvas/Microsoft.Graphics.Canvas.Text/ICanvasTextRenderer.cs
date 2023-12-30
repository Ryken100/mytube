using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2595155173u, 36105, 19044, 179, 34, 175, 3, 4, 33, 178, 228)]
	[Version(167772160u)]
	public interface ICanvasTextRenderer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] object brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint characterIndex, [In] CanvasGlyphOrientation glyphOrientation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DrawStrikethrough([In] Vector2 point, [In] float strikethroughWidth, [In] float strikethroughThickness, [In] float strikethroughOffset, [In] CanvasTextDirection textDirection, [In] object brush, [In] CanvasTextMeasuringMode textMeasuringMode, [In] string localeName, [In] CanvasGlyphOrientation glyphOrientation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DrawUnderline([In] Vector2 point, [In] float underlineWidth, [In] float underlineThickness, [In] float underlineOffset, [In] float runHeight, [In] CanvasTextDirection textDirection, [In] object brush, [In] CanvasTextMeasuringMode textMeasuringMode, [In] string localeName, [In] CanvasGlyphOrientation glyphOrientation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DrawInlineObject([In] Vector2 point, [In] ICanvasTextInlineObject inlineObject, [In] bool isSideways, [In] bool isRightToLeft, [In] object brush, [In] CanvasGlyphOrientation glyphOrientation);

		bool PixelSnappingDisabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Matrix3x2 Transform
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
