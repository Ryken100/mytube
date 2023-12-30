using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Windows.Foundation.Metadata.Guid(3132158317u, 16464, 20214, 128, 34, 138, 7, 233, 231, 74, 157)]
	internal interface ICanvasSvgDocumentFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgDocument CreateEmpty([In] ICanvasResourceCreator resourceCreator);
	}
}
