using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Core;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000CF RID: 207
	[Version(167772160U)]
	[Static(typeof(ICanvasSwapChainStatics), 167772160U)]
	[Activatable(typeof(ICanvasSwapChainFactory), 167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasSwapChain : ICanvasSwapChain, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IClosable
	{
		// Token: 0x060006D0 RID: 1744
		public extern CanvasSwapChain([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060006D1 RID: 1745
		public extern CanvasSwapChain([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060006D2 RID: 1746
		public extern CanvasSwapChain([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060006D3 RID: 1747
		public extern CanvasSwapChain([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060006D4 RID: 1748
		[Overload("Present")]
		public extern void Present();

		// Token: 0x060006D5 RID: 1749
		[Overload("PresentWithSyncInterval")]
		public extern void Present([In] int syncInterval);

		// Token: 0x060006D6 RID: 1750
		[Overload("ResizeBuffersWithSize")]
		public extern void ResizeBuffers([In] Size newSize);

		// Token: 0x060006D7 RID: 1751
		[Overload("ResizeBuffersWithWidthAndHeight")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight);

		// Token: 0x060006D8 RID: 1752
		[Overload("ResizeBuffersWithWidthAndHeightAndDpi")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi);

		// Token: 0x060006D9 RID: 1753
		[Overload("ResizeBuffersWithAllOptions")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi, [In] DirectXPixelFormat newFormat, [In] int bufferCount);

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060006DA RID: 1754
		public extern Size Size { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060006DB RID: 1755
		public extern BitmapSize SizeInPixels { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060006DC RID: 1756
		public extern DirectXPixelFormat Format { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060006DD RID: 1757
		public extern int BufferCount { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060006DE RID: 1758
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060006DF RID: 1759
		// (set) Token: 0x060006E0 RID: 1760
		public extern CanvasSwapChainRotation Rotation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060006E1 RID: 1761
		// (set) Token: 0x060006E2 RID: 1762
		public extern Size SourceSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060006E3 RID: 1763
		// (set) Token: 0x060006E4 RID: 1764
		public extern Matrix3x2 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x060006E5 RID: 1765
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		// Token: 0x060006E6 RID: 1766
		public extern void WaitForVerticalBlank();

		// Token: 0x060006E7 RID: 1767
		public extern void Close();

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060006E8 RID: 1768
		public extern float Dpi { get; }

		// Token: 0x060006E9 RID: 1769
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x060006EA RID: 1770
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060006EB RID: 1771
		public extern CanvasDevice Device { get; }

		// Token: 0x060006EC RID: 1772
		[Overload("CreateForCoreWindowWithDpi")]
		public static extern CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float dpi);

		// Token: 0x060006ED RID: 1773
		[Overload("CreateForCoreWindowWithAllOptions")]
		public static extern CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount);
	}
}
