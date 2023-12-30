using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[Activatable(typeof(ICanvasImageSourceFactory), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasImageSource : SurfaceImageSource, ICanvasImageSource, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
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

		public extern CanvasAlphaMode AlphaMode
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
		[Overload("CreateDrawingSession")]
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRectangle")]
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Recreate([In] ICanvasResourceCreator value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);
	}
}
