using System;
using Microsoft.Graphics.Canvas;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x0200000A RID: 10
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	public sealed class VideoEffectHandlerCanvasArgs : IClosable, IVideoEffectHandlerCanvasArgsClass, IStringable
	{
		// Token: 0x0600002C RID: 44
		public extern VideoEffectHandlerCanvasArgs();

		// Token: 0x0600002D RID: 45
		public extern void Close();

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002E RID: 46
		public extern CanvasDrawingSession DrawingSession { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002F RID: 47
		public extern CanvasBitmap InputFrame { get; }

		// Token: 0x06000030 RID: 48
		string IStringable.ToString();
	}
}
