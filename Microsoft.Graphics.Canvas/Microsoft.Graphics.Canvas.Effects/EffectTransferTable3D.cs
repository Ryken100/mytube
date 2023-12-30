using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[Static(typeof(IEffectTransferTable3DStatics), 167772160u)]
	public sealed class EffectTransferTable3D : IEffectTransferTable3D, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern EffectTransferTable3D CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int sizeB, [In] int sizeG, [In] int sizeR);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern EffectTransferTable3D CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int sizeB, [In] int sizeG, [In] int sizeR, [In] DirectXPixelFormat format);
	}
}
