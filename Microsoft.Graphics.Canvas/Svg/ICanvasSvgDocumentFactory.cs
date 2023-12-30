using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C8 RID: 200
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Guid(3132158317U, 16464, 20214, 128, 34, 138, 7, 233, 231, 74, 157)]
	internal interface ICanvasSvgDocumentFactory
	{
		// Token: 0x060005F8 RID: 1528
		CanvasSvgDocument CreateEmpty([In] ICanvasResourceCreator resourceCreator);
	}
}
