using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3154247501u, 65388, 19789, 169, 233, 142, 235, 33, 57, 242, 63)]
	[ExclusiveTo(typeof(CanvasAnimatedDrawEventArgs))]
	internal interface ICanvasAnimatedDrawEventArgs
	{
		CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasTimingInformation Timing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
