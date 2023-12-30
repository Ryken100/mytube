using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000152 RID: 338
	[ExclusiveTo(typeof(LuminanceToAlphaEffect))]
	[Version(167772160U)]
	[Guid(573982976U, 44113, 23507, 139, 210, 214, 38, 252, 154, 101, 249)]
	internal interface ILuminanceToAlphaEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000D4C RID: 3404
		// (set) Token: 0x06000D4D RID: 3405
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
