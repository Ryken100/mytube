using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200018A RID: 394
	[ExclusiveTo(typeof(VignetteEffect))]
	[Version(167772160U)]
	[Guid(1464668063U, 61127, 22921, 172, 83, 19, 88, 104, 207, 94, 12)]
	internal interface IVignetteEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001094 RID: 4244
		// (set) Token: 0x06001095 RID: 4245
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001096 RID: 4246
		// (set) Token: 0x06001097 RID: 4247
		float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001098 RID: 4248
		// (set) Token: 0x06001099 RID: 4249
		float Curve
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600109A RID: 4250
		// (set) Token: 0x0600109B RID: 4251
		Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600109C RID: 4252
		// (set) Token: 0x0600109D RID: 4253
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
