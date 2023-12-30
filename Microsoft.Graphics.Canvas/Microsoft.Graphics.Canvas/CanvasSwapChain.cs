using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Core;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Static(typeof(ICanvasSwapChainStatics), 167772160u)]
	[Activatable(typeof(ICanvasSwapChainFactory), 167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasSwapChain : ICanvasSwapChain, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Matrix3x2 TransformMatrix
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Size SourceSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasSwapChainRotation Rotation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern int BufferCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern DirectXPixelFormat Format
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Size Size
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern BitmapSize SizeInPixels
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Present")]
		public extern void Present();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("PresentWithSyncInterval")]
		public extern void Present([In] int syncInterval);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeBuffersWithSize")]
		public extern void ResizeBuffers([In] Size newSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeBuffersWithWidthAndHeight")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeBuffersWithWidthAndHeightAndDpi")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeBuffersWithAllOptions")]
		public extern void ResizeBuffers([In] float newWidth, [In] float newHeight, [In] float newDpi, [In] DirectXPixelFormat newFormat, [In] int bufferCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void WaitForVerticalBlank();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateForCoreWindowWithDpi")]
		public static extern CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateForCoreWindowWithAllOptions")]
		public static extern CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount);
	}
}
