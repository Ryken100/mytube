using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000174 RID: 372
	[Guid(2522858082U, 11962, 23014, 147, 95, 35, 137, 203, 90, 48, 90)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(StraightenEffect))]
	internal interface IStraightenEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F5A RID: 3930
		// (set) Token: 0x06000F5B RID: 3931
		float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F5C RID: 3932
		// (set) Token: 0x06000F5D RID: 3933
		bool MaintainSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F5E RID: 3934
		// (set) Token: 0x06000F5F RID: 3935
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000F60 RID: 3936
		// (set) Token: 0x06000F61 RID: 3937
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
