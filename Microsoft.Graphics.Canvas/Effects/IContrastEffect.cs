using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000126 RID: 294
	[ExclusiveTo(typeof(ContrastEffect))]
	[Guid(3666488223U, 22862, 22026, 158, 170, 31, 145, 36, 8, 254, 121)]
	[Version(167772160U)]
	internal interface IContrastEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A38 RID: 2616
		// (set) Token: 0x06000A39 RID: 2617
		float Contrast
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A3A RID: 2618
		// (set) Token: 0x06000A3B RID: 2619
		bool ClampSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000A3C RID: 2620
		// (set) Token: 0x06000A3D RID: 2621
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
