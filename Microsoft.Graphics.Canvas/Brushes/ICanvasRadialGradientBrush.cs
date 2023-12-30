using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000041 RID: 65
	[ExclusiveTo(typeof(CanvasRadialGradientBrush))]
	[Guid(1294456662U, 5289, 20151, 151, 63, 230, 97, 77, 79, 137, 231)]
	[Version(167772160U)]
	internal interface ICanvasRadialGradientBrush : ICanvasBrush, IClosable
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CE RID: 206
		// (set) Token: 0x060000CF RID: 207
		Vector2 Center
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D0 RID: 208
		// (set) Token: 0x060000D1 RID: 209
		Vector2 OriginOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D2 RID: 210
		// (set) Token: 0x060000D3 RID: 211
		float RadiusX
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D4 RID: 212
		// (set) Token: 0x060000D5 RID: 213
		float RadiusY
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D6 RID: 214
		CanvasGradientStop[] Stops { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D7 RID: 215
		CanvasGradientStopHdr[] StopsHdr { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D8 RID: 216
		CanvasEdgeBehavior EdgeBehavior { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D9 RID: 217
		CanvasColorSpace PreInterpolationSpace { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DA RID: 218
		CanvasColorSpace PostInterpolationSpace { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DB RID: 219
		CanvasBufferPrecision BufferPrecision { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DC RID: 220
		CanvasAlphaMode AlphaMode { get; }
	}
}
