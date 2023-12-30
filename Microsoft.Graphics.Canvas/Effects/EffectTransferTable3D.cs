using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010B RID: 267
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	[Static(typeof(IEffectTransferTable3DStatics), 167772160U)]
	public sealed class EffectTransferTable3D : IEffectTransferTable3D, IClosable
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060008F0 RID: 2288
		public extern CanvasDevice Device { get; }

		// Token: 0x060008F1 RID: 2289
		public extern void Close();

		// Token: 0x060008F2 RID: 2290
		public static extern EffectTransferTable3D CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int sizeB, [In] int sizeG, [In] int sizeR);

		// Token: 0x060008F3 RID: 2291
		public static extern EffectTransferTable3D CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int sizeB, [In] int sizeG, [In] int sizeR, [In] DirectXPixelFormat format);
	}
}
