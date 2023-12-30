using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2327791488u, 20189, 20267, 191, 99, 44, 56, 81, 21, 178, 1)]
	[ExclusiveTo(typeof(CanvasSolidColorBrush))]
	[Version(167772160u)]
	internal interface ICanvasSolidColorBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSolidColorBrush Create([In] ICanvasResourceCreator resourceCreator, [In] Color color);
	}
}
