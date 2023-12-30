using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000164 RID: 356
	[Version(167772160U)]
	[ExclusiveTo(typeof(RgbToHueEffect))]
	[Guid(2091822534U, 40627, 22677, 184, 118, 244, 133, 201, 87, 72, 71)]
	internal interface IRgbToHueEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000E3A RID: 3642
		// (set) Token: 0x06000E3B RID: 3643
		EffectHueColorSpace OutputColorSpace
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000E3C RID: 3644
		// (set) Token: 0x06000E3D RID: 3645
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
