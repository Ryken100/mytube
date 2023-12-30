using System;
using Microsoft.Graphics.Canvas;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000004 RID: 4
	[Guid(1922307277U, 25313, 20639, 75, 212, 252, 121, 135, 117, 234, 111)]
	[Version(16777216U)]
	public interface IVideoEffectHandlerArgs
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7
		CanvasBitmap InputFrame { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8
		CanvasRenderTarget OutputFrame { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9
		CanvasDevice Device { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10
		string ID { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11
		IPropertySet Properties { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12
		string InstanceID { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13
		IReference<TimeSpan> Position { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14
		Matrix3x2 Transform { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000F RID: 15
		Size OutputSize { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000010 RID: 16
		Rect OutputBounds { get; }

		// Token: 0x06000011 RID: 17
		CanvasDrawingSession CreateDrawingSession();
	}
}
