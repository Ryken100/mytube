using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000181 RID: 385
	[Guid(1147654424U, 13287, 23322, 135, 194, 15, 31, 4, 151, 53, 61)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(Transform2DEffect))]
	internal interface ITransform2DEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001018 RID: 4120
		// (set) Token: 0x06001019 RID: 4121
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600101A RID: 4122
		// (set) Token: 0x0600101B RID: 4123
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600101C RID: 4124
		// (set) Token: 0x0600101D RID: 4125
		Matrix3x2 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600101E RID: 4126
		// (set) Token: 0x0600101F RID: 4127
		float Sharpness
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001020 RID: 4128
		// (set) Token: 0x06001021 RID: 4129
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
