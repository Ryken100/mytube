using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017E RID: 382
	[Guid(1922703850U, 50718, 21256, 158, 174, 214, 56, 170, 31, 91, 140)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(TintEffect))]
	internal interface ITintEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000FF8 RID: 4088
		// (set) Token: 0x06000FF9 RID: 4089
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000FFA RID: 4090
		// (set) Token: 0x06000FFB RID: 4091
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000FFC RID: 4092
		// (set) Token: 0x06000FFD RID: 4093
		Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000FFE RID: 4094
		// (set) Token: 0x06000FFF RID: 4095
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
