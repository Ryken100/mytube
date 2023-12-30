using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000120 RID: 288
	[Guid(3870184644U, 34877, 22670, 180, 81, 233, 235, 227, 131, 4, 55)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(ColorMatrixEffect))]
	internal interface IColorMatrixEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009F0 RID: 2544
		// (set) Token: 0x060009F1 RID: 2545
		Matrix5x4 ColorMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060009F2 RID: 2546
		// (set) Token: 0x060009F3 RID: 2547
		CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009F4 RID: 2548
		// (set) Token: 0x060009F5 RID: 2549
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009F6 RID: 2550
		// (set) Token: 0x060009F7 RID: 2551
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
