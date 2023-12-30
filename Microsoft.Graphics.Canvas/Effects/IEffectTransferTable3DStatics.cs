using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010A RID: 266
	[ExclusiveTo(typeof(EffectTransferTable3D))]
	[Version(167772160U)]
	[Guid(1018705241U, 8554, 19402, 155, 182, 226, 51, 197, 173, 44, 72)]
	internal interface IEffectTransferTable3DStatics
	{
		// Token: 0x060008EE RID: 2286
		EffectTransferTable3D CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int sizeB, [In] int sizeG, [In] int sizeR);

		// Token: 0x060008EF RID: 2287
		EffectTransferTable3D CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int sizeB, [In] int sizeG, [In] int sizeR, [In] DirectXPixelFormat format);
	}
}
