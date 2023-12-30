using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000135 RID: 309
	[Guid(3573657867U, 46149, 20724, 139, 143, 205, 236, 252, 221, 19, 33)]
	[ExclusiveTo(typeof(DistantDiffuseEffect))]
	[Version(167772160U)]
	internal interface IDistantDiffuseEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000B40 RID: 2880
		// (set) Token: 0x06000B41 RID: 2881
		float Azimuth
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000B42 RID: 2882
		// (set) Token: 0x06000B43 RID: 2883
		float Elevation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000B44 RID: 2884
		// (set) Token: 0x06000B45 RID: 2885
		float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000B46 RID: 2886
		// (set) Token: 0x06000B47 RID: 2887
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000B48 RID: 2888
		// (set) Token: 0x06000B49 RID: 2889
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000B4A RID: 2890
		// (set) Token: 0x06000B4B RID: 2891
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000B4C RID: 2892
		// (set) Token: 0x06000B4D RID: 2893
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000B4E RID: 2894
		// (set) Token: 0x06000B4F RID: 2895
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000B50 RID: 2896
		// (set) Token: 0x06000B51 RID: 2897
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
