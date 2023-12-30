using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200002A RID: 42
	[Guid(2034853587U, 27236, 18409, 141, 168, 180, 106, 170, 36, 213, 59)]
	[Version(167772160U)]
	public interface ICanvasImage : IGraphicsEffectSource, IClosable
	{
		// Token: 0x06000030 RID: 48
		[Overload("GetBounds")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000031 RID: 49
		[Overload("GetBoundsWithTransform")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);
	}
}
