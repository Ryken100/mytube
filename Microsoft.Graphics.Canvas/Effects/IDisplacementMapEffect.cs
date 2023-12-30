using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000133 RID: 307
	[Guid(1173716048U, 54489, 23281, 138, 107, 80, 55, 143, 52, 152, 162)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(DisplacementMapEffect))]
	internal interface IDisplacementMapEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000B1E RID: 2846
		// (set) Token: 0x06000B1F RID: 2847
		float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000B20 RID: 2848
		// (set) Token: 0x06000B21 RID: 2849
		EffectChannelSelect XChannelSelect
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000B22 RID: 2850
		// (set) Token: 0x06000B23 RID: 2851
		EffectChannelSelect YChannelSelect
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000B24 RID: 2852
		// (set) Token: 0x06000B25 RID: 2853
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000B26 RID: 2854
		// (set) Token: 0x06000B27 RID: 2855
		IGraphicsEffectSource Displacement
		{
			get; [param: In]
			set;
		}
	}
}
