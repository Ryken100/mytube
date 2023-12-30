using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012A RID: 298
	[ExclusiveTo(typeof(CropEffect))]
	[Version(167772160U)]
	[Guid(3634479781U, 57393, 22125, 143, 124, 186, 7, 207, 181, 138, 174)]
	internal interface ICropEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A90 RID: 2704
		// (set) Token: 0x06000A91 RID: 2705
		Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A92 RID: 2706
		// (set) Token: 0x06000A93 RID: 2707
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A94 RID: 2708
		// (set) Token: 0x06000A95 RID: 2709
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
