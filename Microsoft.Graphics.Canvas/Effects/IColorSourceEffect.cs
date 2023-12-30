using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000122 RID: 290
	[Guid(637092551U, 32750, 20874, 186, 123, 34, 160, 6, 10, 247, 246)]
	[ExclusiveTo(typeof(ColorSourceEffect))]
	[Version(167772160U)]
	internal interface IColorSourceEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000A0E RID: 2574
		// (set) Token: 0x06000A0F RID: 2575
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000A10 RID: 2576
		// (set) Token: 0x06000A11 RID: 2577
		Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}
	}
}
