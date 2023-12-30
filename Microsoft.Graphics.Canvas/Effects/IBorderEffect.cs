using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000116 RID: 278
	[Version(167772160U)]
	[Guid(828384321U, 5595, 23370, 152, 221, 186, 66, 71, 84, 139, 65)]
	[ExclusiveTo(typeof(BorderEffect))]
	internal interface IBorderEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600096A RID: 2410
		// (set) Token: 0x0600096B RID: 2411
		CanvasEdgeBehavior ExtendX
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600096C RID: 2412
		// (set) Token: 0x0600096D RID: 2413
		CanvasEdgeBehavior ExtendY
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600096E RID: 2414
		// (set) Token: 0x0600096F RID: 2415
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
