using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000157 RID: 343
	[Version(167772160U)]
	[Guid(2494999925U, 50496, 20920, 169, 209, 84, 65, 116, 173, 198, 141)]
	[ExclusiveTo(typeof(OpacityEffect))]
	internal interface IOpacityEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000D7C RID: 3452
		// (set) Token: 0x06000D7D RID: 3453
		float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000D7E RID: 3454
		// (set) Token: 0x06000D7F RID: 3455
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
