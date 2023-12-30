using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200011A RID: 282
	[ExclusiveTo(typeof(ChromaKeyEffect))]
	[Version(167772160U)]
	[Guid(4048262244U, 6257, 24234, 157, 182, 192, 144, 17, 64, 233, 211)]
	internal interface IChromaKeyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600099E RID: 2462
		// (set) Token: 0x0600099F RID: 2463
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060009A0 RID: 2464
		// (set) Token: 0x060009A1 RID: 2465
		float Tolerance
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009A2 RID: 2466
		// (set) Token: 0x060009A3 RID: 2467
		bool InvertAlpha
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060009A4 RID: 2468
		// (set) Token: 0x060009A5 RID: 2469
		bool Feather
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060009A6 RID: 2470
		// (set) Token: 0x060009A7 RID: 2471
		Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060009A8 RID: 2472
		// (set) Token: 0x060009A9 RID: 2473
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
