using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000160 RID: 352
	[Version(167772160U)]
	[Guid(795023931U, 51354, 20604, 151, 86, 41, 155, 97, 67, 79, 164)]
	[ExclusiveTo(typeof(PosterizeEffect))]
	internal interface IPosterizeEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000E0A RID: 3594
		// (set) Token: 0x06000E0B RID: 3595
		int RedValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000E0C RID: 3596
		// (set) Token: 0x06000E0D RID: 3597
		int GreenValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000E0E RID: 3598
		// (set) Token: 0x06000E0F RID: 3599
		int BlueValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000E10 RID: 3600
		// (set) Token: 0x06000E11 RID: 3601
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
