using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasTextLayout))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(2133561341u, 26933, 20320, 180, 9, 99, 148, 161, 156, 94, 188)]
	internal interface ICanvasTextLayoutStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Matrix3x2 GetGlyphOrientationTransform([In] CanvasGlyphOrientation glyphOrientation, [In] bool isSideways, [In] Vector2 position);
	}
}
