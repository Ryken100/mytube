using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000170 RID: 368
	[Version(167772160U)]
	[ExclusiveTo(typeof(SpotDiffuseEffect))]
	[Guid(3017588292U, 7639, 23731, 149, 229, 164, 137, 116, 205, 18, 232)]
	internal interface ISpotDiffuseEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000EE2 RID: 3810
		// (set) Token: 0x06000EE3 RID: 3811
		Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000EE4 RID: 3812
		// (set) Token: 0x06000EE5 RID: 3813
		Vector3 LightTarget
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000EE6 RID: 3814
		// (set) Token: 0x06000EE7 RID: 3815
		float Focus
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000EE8 RID: 3816
		// (set) Token: 0x06000EE9 RID: 3817
		float LimitingConeAngle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000EEA RID: 3818
		// (set) Token: 0x06000EEB RID: 3819
		float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000EEC RID: 3820
		// (set) Token: 0x06000EED RID: 3821
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000EEE RID: 3822
		// (set) Token: 0x06000EEF RID: 3823
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000EF0 RID: 3824
		// (set) Token: 0x06000EF1 RID: 3825
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000EF2 RID: 3826
		// (set) Token: 0x06000EF3 RID: 3827
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000EF4 RID: 3828
		// (set) Token: 0x06000EF5 RID: 3829
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000EF6 RID: 3830
		// (set) Token: 0x06000EF7 RID: 3831
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
