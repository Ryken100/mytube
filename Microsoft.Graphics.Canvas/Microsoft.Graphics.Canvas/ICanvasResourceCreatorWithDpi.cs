using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(443921682u, 59898, 18918, 168, 118, 56, 202, 225, 148, 1, 62)]
	[Version(167772160u)]
	public interface ICanvasResourceCreatorWithDpi : ICanvasResourceCreator
	{
		float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);
	}
}
