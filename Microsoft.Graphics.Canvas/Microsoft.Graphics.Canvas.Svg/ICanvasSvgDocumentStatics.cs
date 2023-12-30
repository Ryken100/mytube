using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2000742216u, 52122, 17727, 166, 120, 139, 59, 58, 114, 84, 211)]
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Version(167772160u)]
	internal interface ICanvasSvgDocumentStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgDocument LoadFromXml([In] ICanvasResourceCreator resourceCreator, [In] string xmlString);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncOperation<CanvasSvgDocument> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsSupported([In] CanvasDevice device);
	}
}
