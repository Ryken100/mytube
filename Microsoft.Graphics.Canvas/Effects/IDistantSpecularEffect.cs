using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000137 RID: 311
	[Guid(2812815583U, 12402, 21599, 141, 117, 134, 193, 0, 240, 50, 49)]
	[ExclusiveTo(typeof(DistantSpecularEffect))]
	[Version(167772160U)]
	internal interface IDistantSpecularEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000B72 RID: 2930
		// (set) Token: 0x06000B73 RID: 2931
		float Azimuth
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000B74 RID: 2932
		// (set) Token: 0x06000B75 RID: 2933
		float Elevation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B76 RID: 2934
		// (set) Token: 0x06000B77 RID: 2935
		float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B78 RID: 2936
		// (set) Token: 0x06000B79 RID: 2937
		float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B7A RID: 2938
		// (set) Token: 0x06000B7B RID: 2939
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B7C RID: 2940
		// (set) Token: 0x06000B7D RID: 2941
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B7E RID: 2942
		// (set) Token: 0x06000B7F RID: 2943
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000B80 RID: 2944
		// (set) Token: 0x06000B81 RID: 2945
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000B82 RID: 2946
		// (set) Token: 0x06000B83 RID: 2947
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000B84 RID: 2948
		// (set) Token: 0x06000B85 RID: 2949
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
