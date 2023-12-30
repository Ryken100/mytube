using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000118 RID: 280
	[Version(167772160U)]
	[Guid(3201225543U, 607, 22311, 143, 125, 73, 141, 103, 223, 85, 126)]
	[ExclusiveTo(typeof(BrightnessEffect))]
	internal interface IBrightnessEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000984 RID: 2436
		// (set) Token: 0x06000985 RID: 2437
		Vector2 WhitePoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000986 RID: 2438
		// (set) Token: 0x06000987 RID: 2439
		Vector2 BlackPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000988 RID: 2440
		// (set) Token: 0x06000989 RID: 2441
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
