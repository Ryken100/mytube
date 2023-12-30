using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3289172825u, 7047, 17300, 166, 166, 236, 210, 120, 232, 119, 214)]
	[ExclusiveTo(typeof(CanvasImageBrush))]
	[Version(167772160u)]
	internal interface ICanvasImageBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageBrush Create([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageBrush CreateWithImage([In] ICanvasResourceCreator resourceCreator, [In] ICanvasImage image);
	}
}
