using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015E RID: 350
	[Guid(3968532123U, 34049, 21126, 164, 60, 26, 255, 247, 66, 10, 214)]
	[ExclusiveTo(typeof(PointSpecularEffect))]
	[Version(167772160U)]
	internal interface IPointSpecularEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000DD8 RID: 3544
		// (set) Token: 0x06000DD9 RID: 3545
		Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000DDA RID: 3546
		// (set) Token: 0x06000DDB RID: 3547
		float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000DDC RID: 3548
		// (set) Token: 0x06000DDD RID: 3549
		float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000DDE RID: 3550
		// (set) Token: 0x06000DDF RID: 3551
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000DE0 RID: 3552
		// (set) Token: 0x06000DE1 RID: 3553
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000DE2 RID: 3554
		// (set) Token: 0x06000DE3 RID: 3555
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000DE4 RID: 3556
		// (set) Token: 0x06000DE5 RID: 3557
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000DE6 RID: 3558
		// (set) Token: 0x06000DE7 RID: 3559
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000DE8 RID: 3560
		// (set) Token: 0x06000DE9 RID: 3561
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
