using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2034853587u, 27236, 18409, 141, 168, 180, 106, 170, 36, 213, 59)]
	[Version(167772160u)]
	public interface ICanvasImage : IGraphicsEffectSource, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBounds")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBoundsWithTransform")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);
	}
}
