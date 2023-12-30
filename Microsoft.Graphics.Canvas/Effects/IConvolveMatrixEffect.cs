using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000128 RID: 296
	[Version(167772160U)]
	[Guid(2190873175U, 42893, 21568, 128, 38, 175, 87, 212, 167, 106, 158)]
	[ExclusiveTo(typeof(ConvolveMatrixEffect))]
	internal interface IConvolveMatrixEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A52 RID: 2642
		// (set) Token: 0x06000A53 RID: 2643
		Vector2 KernelScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A54 RID: 2644
		// (set) Token: 0x06000A55 RID: 2645
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A56 RID: 2646
		// (set) Token: 0x06000A57 RID: 2647
		int KernelWidth
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A58 RID: 2648
		// (set) Token: 0x06000A59 RID: 2649
		int KernelHeight
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A5A RID: 2650
		// (set) Token: 0x06000A5B RID: 2651
		float[] KernelMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A5C RID: 2652
		// (set) Token: 0x06000A5D RID: 2653
		float Divisor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A5E RID: 2654
		// (set) Token: 0x06000A5F RID: 2655
		float Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A60 RID: 2656
		// (set) Token: 0x06000A61 RID: 2657
		Vector2 KernelOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A62 RID: 2658
		// (set) Token: 0x06000A63 RID: 2659
		bool PreserveAlpha
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A64 RID: 2660
		// (set) Token: 0x06000A65 RID: 2661
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A66 RID: 2662
		// (set) Token: 0x06000A67 RID: 2663
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A68 RID: 2664
		// (set) Token: 0x06000A69 RID: 2665
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
