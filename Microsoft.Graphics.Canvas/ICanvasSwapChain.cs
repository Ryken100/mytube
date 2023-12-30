using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX;
using Windows.Graphics.Imaging;
using Windows.UI;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000D1 RID: 209
	[ExclusiveTo(typeof(CanvasSwapChain))]
	[Guid(2284731450U, 22309, 16540, 158, 118, 248, 11, 59, 172, 241, 180)]
	[Version(167772160U)]
	internal interface ICanvasSwapChain : IClosable, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060006F0 RID: 1776
		[Overload("Present")]
		void Present();

		// Token: 0x060006F1 RID: 1777
		[Overload("PresentWithSyncInterval")]
		void Present([In] int syncInterval);

		// Token: 0x060006F2 RID: 1778
		[Overload("ResizeBuffersWithSize")]
		void ResizeBuffers([In] Size newSize);

		// Token: 0x060006F3 RID: 1779
		[Overload("ResizeBuffersWithWidthAndHeight")]
		void ResizeBuffers([In] float newWidth, [In] float newHeight);

		// Token: 0x060006F4 RID: 1780
		[Overload("ResizeBuffersWithWidthAndHeightAndDpi")]
		void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi);

		// Token: 0x060006F5 RID: 1781
		[Overload("ResizeBuffersWithAllOptions")]
		void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi, [In] DirectXPixelFormat newFormat, [In] int bufferCount);

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060006F6 RID: 1782
		Size Size { get; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060006F7 RID: 1783
		BitmapSize SizeInPixels { get; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060006F8 RID: 1784
		DirectXPixelFormat Format { get; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060006F9 RID: 1785
		int BufferCount { get; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060006FA RID: 1786
		CanvasAlphaMode AlphaMode { get; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060006FB RID: 1787
		// (set) Token: 0x060006FC RID: 1788
		CanvasSwapChainRotation Rotation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060006FD RID: 1789
		// (set) Token: 0x060006FE RID: 1790
		Size SourceSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060006FF RID: 1791
		// (set) Token: 0x06000700 RID: 1792
		Matrix3x2 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000701 RID: 1793
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		// Token: 0x06000702 RID: 1794
		void WaitForVerticalBlank();
	}
}
