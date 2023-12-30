using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014A RID: 330
	[Version(167772160U)]
	[Guid(3245534194U, 58207, 22702, 173, 44, 86, 30, 206, 175, 38, 148)]
	[ExclusiveTo(typeof(HueRotationEffect))]
	internal interface IHueRotationEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000CC8 RID: 3272
		// (set) Token: 0x06000CC9 RID: 3273
		float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000CCA RID: 3274
		// (set) Token: 0x06000CCB RID: 3275
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
