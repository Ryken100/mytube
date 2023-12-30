using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000183 RID: 387
	[Version(167772160U)]
	[Guid(807791999U, 36645, 24075, 128, 201, 86, 187, 221, 62, 138, 16)]
	[ExclusiveTo(typeof(Transform3DEffect))]
	internal interface ITransform3DEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600103A RID: 4154
		// (set) Token: 0x0600103B RID: 4155
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600103C RID: 4156
		// (set) Token: 0x0600103D RID: 4157
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600103E RID: 4158
		// (set) Token: 0x0600103F RID: 4159
		Matrix4x4 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001040 RID: 4160
		// (set) Token: 0x06001041 RID: 4161
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
