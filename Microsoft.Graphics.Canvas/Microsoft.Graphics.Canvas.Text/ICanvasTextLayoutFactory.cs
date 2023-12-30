using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(2619306361u, 44240, 18048, 147, 213, 149, 166, 36, 126, 143, 107)]
	[ExclusiveTo(typeof(CanvasTextLayout))]
	internal interface ICanvasTextLayoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextLayout Create([In] ICanvasResourceCreator resourceCreator, [In] string textString, [In] CanvasTextFormat textFormat, [In] float requestedWidth, [In] float requestedHeight);
	}
}
