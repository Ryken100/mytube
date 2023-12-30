using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1010165882u, 59521, 20292, 176, 209, 85, 20, 19, 174, 198, 109)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasImageSource))]
	internal interface ICanvasImageSource : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSession")]
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRectangle")]
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Recreate([In] ICanvasResourceCreator value);

		Size Size
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		BitmapSize SizeInPixels
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
