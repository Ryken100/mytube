using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3234397612u, 3580, 19992, 166, 233, 158, 247, 220, 130, 188, 194)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasAnimatedDrawEventArgs))]
	internal interface ICanvasAnimatedDrawEventArgsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasAnimatedDrawEventArgs Create([In] CanvasDrawingSession canvasDrawingSession, [In] CanvasTimingInformation timingInformation);
	}
}
