using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014C RID: 332
	[Version(167772160U)]
	[Guid(513261868U, 46915, 21456, 136, 196, 132, 53, 39, 43, 10, 61)]
	[ExclusiveTo(typeof(HueToRgbEffect))]
	internal interface IHueToRgbEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000CDE RID: 3294
		// (set) Token: 0x06000CDF RID: 3295
		EffectHueColorSpace SourceColorSpace
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000CE0 RID: 3296
		// (set) Token: 0x06000CE1 RID: 3297
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
