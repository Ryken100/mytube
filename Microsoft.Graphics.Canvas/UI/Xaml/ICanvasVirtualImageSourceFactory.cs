using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F4 RID: 244
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasVirtualImageSource))]
	[Guid(803689889U, 12410, 17955, 146, 80, 41, 89, 4, 133, 189, 182)]
	internal interface ICanvasVirtualImageSourceFactory
	{
		// Token: 0x060007D0 RID: 2000
		CanvasVirtualImageSource CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060007D1 RID: 2001
		CanvasVirtualImageSource CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060007D2 RID: 2002
		CanvasVirtualImageSource CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060007D3 RID: 2003
		CanvasVirtualImageSource CreateWithWidthAndHeightAndDpiAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);
	}
}
