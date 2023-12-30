using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000144 RID: 324
	[Version(167772160U)]
	[Guid(2821637012U, 26420, 22576, 145, 35, 44, 130, 178, 125, 211, 192)]
	[ExclusiveTo(typeof(GaussianBlurEffect))]
	internal interface IGaussianBlurEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000C72 RID: 3186
		// (set) Token: 0x06000C73 RID: 3187
		float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000C74 RID: 3188
		// (set) Token: 0x06000C75 RID: 3189
		EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000C76 RID: 3190
		// (set) Token: 0x06000C77 RID: 3191
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000C78 RID: 3192
		// (set) Token: 0x06000C79 RID: 3193
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
