using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000048 RID: 72
	[Guid(759984969U, 39474, 16825, 179, 204, 202, 241, 183, 225, 9, 155)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	[Version(167772160U)]
	internal interface ICanvasRenderTarget
	{
		// Token: 0x0600014A RID: 330
		CanvasDrawingSession CreateDrawingSession();
	}
}
