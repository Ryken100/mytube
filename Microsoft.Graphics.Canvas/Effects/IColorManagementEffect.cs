using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200011D RID: 285
	[ExclusiveTo(typeof(ColorManagementEffect))]
	[Version(167772160U)]
	[Guid(1854651959U, 57828, 23248, 185, 141, 148, 14, 50, 19, 165, 78)]
	internal interface IColorManagementEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060009C4 RID: 2500
		// (set) Token: 0x060009C5 RID: 2501
		ColorManagementProfile SourceColorProfile
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060009C6 RID: 2502
		// (set) Token: 0x060009C7 RID: 2503
		ColorManagementRenderingIntent SourceRenderingIntent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060009C8 RID: 2504
		// (set) Token: 0x060009C9 RID: 2505
		ColorManagementProfile OutputColorProfile
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060009CA RID: 2506
		// (set) Token: 0x060009CB RID: 2507
		ColorManagementRenderingIntent OutputRenderingIntent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060009CC RID: 2508
		// (set) Token: 0x060009CD RID: 2509
		CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060009CE RID: 2510
		// (set) Token: 0x060009CF RID: 2511
		ColorManagementEffectQuality Quality
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060009D0 RID: 2512
		// (set) Token: 0x060009D1 RID: 2513
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
