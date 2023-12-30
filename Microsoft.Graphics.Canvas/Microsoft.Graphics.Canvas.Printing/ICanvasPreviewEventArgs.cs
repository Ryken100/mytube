using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(174751904u, 45181, 19890, 189, 235, 3, 104, 187, 24, 192, 248)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasPreviewEventArgs))]
	internal interface ICanvasPreviewEventArgs
	{
		uint PageNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		PrintTaskOptions PrintTaskOptions
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasPrintDeferral GetDeferral();

		CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
