using System;
using Microsoft.Graphics.Canvas;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x0200000B RID: 11
	[Guid(2284576554U, 21306, 22582, 65, 243, 228, 100, 142, 199, 246, 189)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(VideoEffectHandlerCanvasArgs))]
	internal interface IVideoEffectHandlerCanvasArgsClass
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000031 RID: 49
		CanvasDrawingSession DrawingSession { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000032 RID: 50
		CanvasBitmap InputFrame { get; }
	}
}
