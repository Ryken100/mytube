using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017A RID: 378
	[ExclusiveTo(typeof(TemperatureAndTintEffect))]
	[Version(167772160U)]
	[Guid(2330213890U, 9753, 23928, 137, 128, 78, 213, 105, 84, 155, 216)]
	internal interface ITemperatureAndTintEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000FC8 RID: 4040
		// (set) Token: 0x06000FC9 RID: 4041
		float Temperature
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000FCA RID: 4042
		// (set) Token: 0x06000FCB RID: 4043
		float Tint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000FCC RID: 4044
		// (set) Token: 0x06000FCD RID: 4045
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
