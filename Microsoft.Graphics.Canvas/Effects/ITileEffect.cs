using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017C RID: 380
	[Version(167772160U)]
	[Guid(2024278475U, 4436, 23254, 168, 128, 227, 161, 117, 119, 40, 21)]
	[ExclusiveTo(typeof(TileEffect))]
	internal interface ITileEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000FE2 RID: 4066
		// (set) Token: 0x06000FE3 RID: 4067
		Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000FE4 RID: 4068
		// (set) Token: 0x06000FE5 RID: 4069
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
