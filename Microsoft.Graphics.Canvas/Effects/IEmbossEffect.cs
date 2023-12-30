using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200013E RID: 318
	[ExclusiveTo(typeof(EmbossEffect))]
	[Guid(1635516213U, 18460, 21910, 171, 165, 0, 161, 98, 52, 157, 123)]
	[Version(167772160U)]
	internal interface IEmbossEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000BEC RID: 3052
		// (set) Token: 0x06000BED RID: 3053
		float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000BEE RID: 3054
		// (set) Token: 0x06000BEF RID: 3055
		float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000BF0 RID: 3056
		// (set) Token: 0x06000BF1 RID: 3057
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
