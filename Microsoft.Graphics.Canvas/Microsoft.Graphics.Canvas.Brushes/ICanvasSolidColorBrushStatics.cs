using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1654354500u, 23454, 20216, 142, 9, 38, 71, 20, 32, 30, 232)]
	[ExclusiveTo(typeof(CanvasSolidColorBrush))]
	internal interface ICanvasSolidColorBrushStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSolidColorBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 colorHdr);
	}
}
