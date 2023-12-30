using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000114 RID: 276
	[ExclusiveTo(typeof(BlendEffect))]
	[Guid(1450386574U, 29286, 24137, 178, 171, 37, 137, 213, 216, 117, 195)]
	[Version(167772160U)]
	internal interface IBlendEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000950 RID: 2384
		// (set) Token: 0x06000951 RID: 2385
		BlendEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000952 RID: 2386
		// (set) Token: 0x06000953 RID: 2387
		IGraphicsEffectSource Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000954 RID: 2388
		// (set) Token: 0x06000955 RID: 2389
		IGraphicsEffectSource Foreground
		{
			get; [param: In]
			set;
		}
	}
}
