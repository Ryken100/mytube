using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000172 RID: 370
	[Version(167772160U)]
	[Guid(2209238224U, 32938, 22403, 133, 114, 241, 94, 95, 133, 50, 158)]
	[ExclusiveTo(typeof(SpotSpecularEffect))]
	internal interface ISpotSpecularEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000F1C RID: 3868
		// (set) Token: 0x06000F1D RID: 3869
		Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000F1E RID: 3870
		// (set) Token: 0x06000F1F RID: 3871
		Vector3 LightTarget
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000F20 RID: 3872
		// (set) Token: 0x06000F21 RID: 3873
		float Focus
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000F22 RID: 3874
		// (set) Token: 0x06000F23 RID: 3875
		float LimitingConeAngle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F24 RID: 3876
		// (set) Token: 0x06000F25 RID: 3877
		float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F26 RID: 3878
		// (set) Token: 0x06000F27 RID: 3879
		float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F28 RID: 3880
		// (set) Token: 0x06000F29 RID: 3881
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000F2A RID: 3882
		// (set) Token: 0x06000F2B RID: 3883
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F2C RID: 3884
		// (set) Token: 0x06000F2D RID: 3885
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000F2E RID: 3886
		// (set) Token: 0x06000F2F RID: 3887
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000F30 RID: 3888
		// (set) Token: 0x06000F31 RID: 3889
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000F32 RID: 3890
		// (set) Token: 0x06000F33 RID: 3891
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
