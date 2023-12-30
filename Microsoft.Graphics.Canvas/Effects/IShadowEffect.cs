using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016C RID: 364
	[Guid(961005089U, 30938, 21641, 153, 39, 190, 101, 95, 69, 118, 226)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(ShadowEffect))]
	internal interface IShadowEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000EA6 RID: 3750
		// (set) Token: 0x06000EA7 RID: 3751
		float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000EA8 RID: 3752
		// (set) Token: 0x06000EA9 RID: 3753
		Color ShadowColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000EAA RID: 3754
		// (set) Token: 0x06000EAB RID: 3755
		EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000EAC RID: 3756
		// (set) Token: 0x06000EAD RID: 3757
		Vector4 ShadowColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000EAE RID: 3758
		// (set) Token: 0x06000EAF RID: 3759
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
