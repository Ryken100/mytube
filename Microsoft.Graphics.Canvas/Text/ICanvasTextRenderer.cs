using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000053 RID: 83
	[Guid(2595155173U, 36105, 19044, 179, 34, 175, 3, 4, 33, 178, 228)]
	[Version(167772160U)]
	public interface ICanvasTextRenderer
	{
		// Token: 0x0600025F RID: 607
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] object brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint characterIndex, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x06000260 RID: 608
		void DrawStrikethrough([In] Vector2 point, [In] float strikethroughWidth, [In] float strikethroughThickness, [In] float strikethroughOffset, [In] CanvasTextDirection textDirection, [In] object brush, [In] CanvasTextMeasuringMode textMeasuringMode, [In] string localeName, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x06000261 RID: 609
		void DrawUnderline([In] Vector2 point, [In] float underlineWidth, [In] float underlineThickness, [In] float underlineOffset, [In] float runHeight, [In] CanvasTextDirection textDirection, [In] object brush, [In] CanvasTextMeasuringMode textMeasuringMode, [In] string localeName, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x06000262 RID: 610
		void DrawInlineObject([In] Vector2 point, [In] ICanvasTextInlineObject inlineObject, [In] bool isSideways, [In] bool isRightToLeft, [In] object brush, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000263 RID: 611
		bool PixelSnappingDisabled { get; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000264 RID: 612
		Matrix3x2 Transform { get; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000265 RID: 613
		float Dpi { get; }
	}
}
