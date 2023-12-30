using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000148 RID: 328
	[Guid(2140192276U, 9854, 20616, 188, 54, 46, 10, 173, 134, 155, 82)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(HighlightsAndShadowsEffect))]
	internal interface IHighlightsAndShadowsEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000CA2 RID: 3234
		// (set) Token: 0x06000CA3 RID: 3235
		float Highlights
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000CA4 RID: 3236
		// (set) Token: 0x06000CA5 RID: 3237
		float Shadows
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000CA6 RID: 3238
		// (set) Token: 0x06000CA7 RID: 3239
		float Clarity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000CA8 RID: 3240
		// (set) Token: 0x06000CA9 RID: 3241
		float MaskBlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000CAA RID: 3242
		// (set) Token: 0x06000CAB RID: 3243
		bool SourceIsLinearGamma
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000CAC RID: 3244
		// (set) Token: 0x06000CAD RID: 3245
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
