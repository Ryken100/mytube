using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasCommandList))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3017035368u, 55601, 19291, 185, 87, 8, 136, 152, 10, 125, 80)]
	internal interface ICanvasCommandListFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasCommandList Create([In] ICanvasResourceCreator resourceCreator);
	}
}
