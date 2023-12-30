using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2888560148u, 61393, 17219, 142, 83, 186, 98, 21, 61, 137, 102)]
	[ExclusiveTo(typeof(CanvasPathBuilder))]
	[Version(167772160u)]
	internal interface ICanvasPathBuilderFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasPathBuilder Create([In] ICanvasResourceCreator resourceCreator);
	}
}
