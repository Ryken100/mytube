using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(759984969u, 39474, 16825, 179, 204, 202, 241, 183, 225, 9, 155)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	[Version(167772160u)]
	internal interface ICanvasRenderTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDrawingSession CreateDrawingSession();
	}
}
