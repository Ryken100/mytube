using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016E RID: 366
	[ExclusiveTo(typeof(SharpenEffect))]
	[Guid(2130636961U, 30072, 24418, 131, 100, 70, 20, 86, 116, 239, 126)]
	[Version(167772160U)]
	internal interface ISharpenEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000EC8 RID: 3784
		// (set) Token: 0x06000EC9 RID: 3785
		float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000ECA RID: 3786
		// (set) Token: 0x06000ECB RID: 3787
		float Threshold
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000ECC RID: 3788
		// (set) Token: 0x06000ECD RID: 3789
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
