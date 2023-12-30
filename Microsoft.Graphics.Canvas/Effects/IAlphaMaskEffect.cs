using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010C RID: 268
	[ExclusiveTo(typeof(AlphaMaskEffect))]
	[Version(167772160U)]
	[Guid(2611372158U, 30153, 21384, 137, 47, 221, 52, 64, 86, 77, 152)]
	internal interface IAlphaMaskEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060008F4 RID: 2292
		// (set) Token: 0x060008F5 RID: 2293
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060008F6 RID: 2294
		// (set) Token: 0x060008F7 RID: 2295
		IGraphicsEffectSource AlphaMask
		{
			get; [param: In]
			set;
		}
	}
}
