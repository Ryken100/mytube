using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000111 RID: 273
	[ExclusiveTo(typeof(AtlasEffect))]
	[Guid(4159860410U, 61461, 24319, 154, 243, 123, 210, 212, 73, 4, 189)]
	[Version(167772160U)]
	internal interface IAtlasEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000936 RID: 2358
		// (set) Token: 0x06000937 RID: 2359
		Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000938 RID: 2360
		// (set) Token: 0x06000939 RID: 2361
		Rect PaddingRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600093A RID: 2362
		// (set) Token: 0x0600093B RID: 2363
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
