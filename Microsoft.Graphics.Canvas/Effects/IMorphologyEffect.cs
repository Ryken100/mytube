using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000155 RID: 341
	[ExclusiveTo(typeof(MorphologyEffect))]
	[Guid(4278607835U, 25288, 22536, 146, 30, 73, 239, 164, 58, 61, 52)]
	[Version(167772160U)]
	internal interface IMorphologyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000D5E RID: 3422
		// (set) Token: 0x06000D5F RID: 3423
		MorphologyEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000D60 RID: 3424
		// (set) Token: 0x06000D61 RID: 3425
		int Width
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000D62 RID: 3426
		// (set) Token: 0x06000D63 RID: 3427
		int Height
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000D64 RID: 3428
		// (set) Token: 0x06000D65 RID: 3429
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
