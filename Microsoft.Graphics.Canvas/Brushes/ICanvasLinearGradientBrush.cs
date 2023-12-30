using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003D RID: 61
	[Guid(2768223409U, 60450, 18632, 177, 175, 9, 188, 253, 52, 238, 189)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasLinearGradientBrush))]
	internal interface ICanvasLinearGradientBrush : ICanvasBrush, IClosable
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009C RID: 156
		// (set) Token: 0x0600009D RID: 157
		Vector2 StartPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158
		// (set) Token: 0x0600009F RID: 159
		Vector2 EndPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A0 RID: 160
		CanvasGradientStop[] Stops { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A1 RID: 161
		CanvasGradientStopHdr[] StopsHdr { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A2 RID: 162
		CanvasEdgeBehavior EdgeBehavior { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A3 RID: 163
		CanvasColorSpace PreInterpolationSpace { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A4 RID: 164
		CanvasColorSpace PostInterpolationSpace { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A5 RID: 165
		CanvasBufferPrecision BufferPrecision { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A6 RID: 166
		CanvasAlphaMode AlphaMode { get; }
	}
}
