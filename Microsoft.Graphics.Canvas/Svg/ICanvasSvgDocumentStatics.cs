using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C7 RID: 199
	[Guid(2000742216U, 52122, 17727, 166, 120, 139, 59, 58, 114, 84, 211)]
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Version(167772160U)]
	internal interface ICanvasSvgDocumentStatics
	{
		// Token: 0x060005F5 RID: 1525
		CanvasSvgDocument LoadFromXml([In] ICanvasResourceCreator resourceCreator, [In] string xmlString);

		// Token: 0x060005F6 RID: 1526
		IAsyncOperation<CanvasSvgDocument> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x060005F7 RID: 1527
		bool IsSupported([In] CanvasDevice device);
	}
}
