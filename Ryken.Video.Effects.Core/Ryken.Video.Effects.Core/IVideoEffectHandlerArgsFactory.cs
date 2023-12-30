using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3111591436u, 24577, 21595, 113, 83, 132, 149, 233, 85, 170, 106)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(VideoEffectHandlerArgs))]
	internal interface IVideoEffectHandlerArgsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		VideoEffectHandlerArgs CreateVideoEffectHandlerArgs([In] CanvasDevice device, [In] CanvasBitmap inputFrame, [In] CanvasRenderTarget outputFrame, [In] string id, [In] string instanceId, [In] IPropertySet properties, [In] TimeSpan? position);
	}
}
