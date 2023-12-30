using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012C RID: 300
	[Guid(3189119647U, 17362, 22035, 134, 0, 213, 30, 61, 124, 226, 136)]
	[ExclusiveTo(typeof(CrossFadeEffect))]
	[Version(167772160U)]
	internal interface ICrossFadeEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000AAA RID: 2730
		// (set) Token: 0x06000AAB RID: 2731
		float CrossFade
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000AAC RID: 2732
		// (set) Token: 0x06000AAD RID: 2733
		IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000AAE RID: 2734
		// (set) Token: 0x06000AAF RID: 2735
		IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}
	}
}
