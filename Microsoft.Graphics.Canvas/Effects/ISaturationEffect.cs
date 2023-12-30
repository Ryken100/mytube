using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000166 RID: 358
	[ExclusiveTo(typeof(SaturationEffect))]
	[Guid(4166672087U, 29202, 22438, 179, 87, 97, 3, 137, 97, 197, 141)]
	[Version(167772160U)]
	internal interface ISaturationEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000E50 RID: 3664
		// (set) Token: 0x06000E51 RID: 3665
		float Saturation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000E52 RID: 3666
		// (set) Token: 0x06000E53 RID: 3667
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
