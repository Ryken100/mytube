using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000139 RID: 313
	[Guid(1667602381U, 63818, 21942, 156, 240, 105, 74, 83, 214, 56, 234)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(DpiCompensationEffect))]
	internal interface IDpiCompensationEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000BA8 RID: 2984
		// (set) Token: 0x06000BA9 RID: 2985
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000BAA RID: 2986
		// (set) Token: 0x06000BAB RID: 2987
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000BAC RID: 2988
		// (set) Token: 0x06000BAD RID: 2989
		Vector2 SourceDpi
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000BAE RID: 2990
		// (set) Token: 0x06000BAF RID: 2991
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
