using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000009 RID: 9
	[Guid(3111591436U, 24577, 21595, 113, 83, 132, 149, 233, 85, 170, 106)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(VideoEffectHandlerArgs))]
	internal interface IVideoEffectHandlerArgsFactory
	{
		// Token: 0x0600002B RID: 43
		VideoEffectHandlerArgs CreateVideoEffectHandlerArgs([In] CanvasDevice device, [In] CanvasBitmap inputFrame, [In] CanvasRenderTarget outputFrame, [In] string id, [In] string instanceId, [In] IPropertySet properties, [In] IReference<TimeSpan> position);
	}
}
