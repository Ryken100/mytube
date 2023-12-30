using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(207702212u, 534, 17761, 168, 23, 52, 200, 148, 42, 172, 139)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasPrintEventArgs))]
	internal interface ICanvasPrintEventArgs
	{
		PrintTaskOptions PrintTaskOptions
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasPrintDeferral GetDeferral();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDrawingSession CreateDrawingSession();
	}
}
