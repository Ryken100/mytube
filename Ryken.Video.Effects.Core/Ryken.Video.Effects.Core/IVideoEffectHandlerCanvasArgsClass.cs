using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2284576554u, 21306, 22582, 65, 243, 228, 100, 142, 199, 246, 189)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(VideoEffectHandlerCanvasArgs))]
	internal interface IVideoEffectHandlerCanvasArgsClass
	{
		CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasBitmap InputFrame
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
