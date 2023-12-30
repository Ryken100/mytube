using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Version(16777216u)]
	[Activatable(16777216u)]
	public sealed class VideoEffectHandlerCanvasArgs : IDisposable, IVideoEffectHandlerCanvasArgsClass, IStringable
	{
		public extern CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasBitmap InputFrame
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		extern string IStringable.ToString();
	}
}
