using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000140 RID: 320
	[ExclusiveTo(typeof(ExposureEffect))]
	[Version(167772160U)]
	[Guid(3118598659U, 8754, 24531, 180, 8, 21, 120, 75, 121, 219, 176)]
	internal interface IExposureEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000C06 RID: 3078
		// (set) Token: 0x06000C07 RID: 3079
		float Exposure
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000C08 RID: 3080
		// (set) Token: 0x06000C09 RID: 3081
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
