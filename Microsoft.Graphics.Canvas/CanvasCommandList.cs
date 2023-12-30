using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000D3 RID: 211
	[Activatable(typeof(ICanvasCommandListFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasCommandList : ICanvasCommandList, ICanvasImage, IClosable, IGraphicsEffectSource
	{
		// Token: 0x06000704 RID: 1796
		public extern CanvasCommandList([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000705 RID: 1797
		public extern CanvasDrawingSession CreateDrawingSession();

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000706 RID: 1798
		public extern CanvasDevice Device { get; }

		// Token: 0x06000707 RID: 1799
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000708 RID: 1800
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000709 RID: 1801
		public extern void Close();
	}
}
