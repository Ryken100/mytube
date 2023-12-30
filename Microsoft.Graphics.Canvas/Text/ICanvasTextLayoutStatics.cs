using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200006F RID: 111
	[ExclusiveTo(typeof(CanvasTextLayout))]
	[Version(167772160U)]
	[Guid(2133561341U, 26933, 20320, 180, 9, 99, 148, 161, 156, 94, 188)]
	internal interface ICanvasTextLayoutStatics
	{
		// Token: 0x060003BF RID: 959
		Matrix3x2 GetGlyphOrientationTransform([In] CanvasGlyphOrientation glyphOrientation, [In] bool isSideways, [In] Vector2 position);
	}
}
