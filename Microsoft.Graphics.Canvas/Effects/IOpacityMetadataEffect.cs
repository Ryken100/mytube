using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015A RID: 346
	[ExclusiveTo(typeof(OpacityMetadataEffect))]
	[Version(167772160U)]
	[Guid(161428121U, 39690, 24275, 176, 68, 74, 111, 201, 111, 131, 98)]
	internal interface IOpacityMetadataEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000D94 RID: 3476
		// (set) Token: 0x06000D95 RID: 3477
		Rect OpaqueRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000D96 RID: 3478
		// (set) Token: 0x06000D97 RID: 3479
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
