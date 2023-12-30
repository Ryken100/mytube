using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(EffectTransferTable3D))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1018705241u, 8554, 19402, 155, 182, 226, 51, 197, 173, 44, 72)]
	internal interface IEffectTransferTable3DStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		EffectTransferTable3D CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int sizeB, [In] int sizeG, [In] int sizeR);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		EffectTransferTable3D CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int sizeB, [In] int sizeG, [In] int sizeR, [In] DirectXPixelFormat format);
	}
}
