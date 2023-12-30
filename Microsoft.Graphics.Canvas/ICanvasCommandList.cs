using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000D4 RID: 212
	[Guid(3072226255U, 12263, 19770, 187, 184, 25, 240, 22, 245, 190, 27)]
	[ExclusiveTo(typeof(CanvasCommandList))]
	[Version(167772160U)]
	internal interface ICanvasCommandList : ICanvasImage, IGraphicsEffectSource, IClosable
	{
		// Token: 0x0600070A RID: 1802
		CanvasDrawingSession CreateDrawingSession();

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600070B RID: 1803
		CanvasDevice Device { get; }
	}
}
