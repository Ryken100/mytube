using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000146 RID: 326
	[ExclusiveTo(typeof(GrayscaleEffect))]
	[Guid(2028026755U, 1592, 21496, 176, 179, 91, 11, 50, 10, 154, 210)]
	[Version(167772160U)]
	internal interface IGrayscaleEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000C90 RID: 3216
		// (set) Token: 0x06000C91 RID: 3217
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
