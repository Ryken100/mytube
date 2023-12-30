using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012F RID: 303
	[ExclusiveTo(typeof(DirectionalBlurEffect))]
	[Version(167772160U)]
	[Guid(1561680971U, 2178, 20586, 168, 225, 18, 225, 234, 209, 127, 10)]
	internal interface IDirectionalBlurEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000AC6 RID: 2758
		// (set) Token: 0x06000AC7 RID: 2759
		float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000AC8 RID: 2760
		// (set) Token: 0x06000AC9 RID: 2761
		float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000ACA RID: 2762
		// (set) Token: 0x06000ACB RID: 2763
		EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000ACC RID: 2764
		// (set) Token: 0x06000ACD RID: 2765
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000ACE RID: 2766
		// (set) Token: 0x06000ACF RID: 2767
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
