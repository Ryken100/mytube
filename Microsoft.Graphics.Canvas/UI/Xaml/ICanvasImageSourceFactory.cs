using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000CA RID: 202
	[Guid(2241248989U, 55287, 19563, 177, 173, 65, 148, 144, 53, 224, 132)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasImageSource))]
	internal interface ICanvasImageSourceFactory
	{
		// Token: 0x060006B4 RID: 1716
		CanvasImageSource CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060006B5 RID: 1717
		CanvasImageSource CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060006B6 RID: 1718
		CanvasImageSource CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060006B7 RID: 1719
		CanvasImageSource CreateWithWidthAndHeightAndDpiAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);
	}
}
