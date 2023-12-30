using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016A RID: 362
	[ExclusiveTo(typeof(SepiaEffect))]
	[Guid(4180887327U, 42927, 21793, 190, 121, 176, 218, 34, 151, 108, 255)]
	[Version(167772160U)]
	internal interface ISepiaEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000E8C RID: 3724
		// (set) Token: 0x06000E8D RID: 3725
		float Intensity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000E8E RID: 3726
		// (set) Token: 0x06000E8F RID: 3727
		CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000E90 RID: 3728
		// (set) Token: 0x06000E91 RID: 3729
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
