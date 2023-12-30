using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1922684716u, 63716, 18991, 158, 48, 124, 223, 204, 243, 28, 68)]
	[ExclusiveTo(typeof(CanvasDrawEventArgs))]
	internal interface ICanvasDrawEventArgsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDrawEventArgs Create([In] CanvasDrawingSession canvasDrawingSession);
	}
}
