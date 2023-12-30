using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3072226255u, 12263, 19770, 187, 184, 25, 240, 22, 245, 190, 27)]
	[ExclusiveTo(typeof(CanvasCommandList))]
	[Version(167772160u)]
	internal interface ICanvasCommandList : ICanvasImage, IGraphicsEffectSource, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDrawingSession CreateDrawingSession();

		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
