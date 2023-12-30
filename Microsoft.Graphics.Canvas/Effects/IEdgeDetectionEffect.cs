using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200013C RID: 316
	[ExclusiveTo(typeof(EdgeDetectionEffect))]
	[Version(167772160U)]
	[Guid(1777782586U, 62351, 23176, 151, 74, 41, 57, 11, 149, 126, 92)]
	internal interface IEdgeDetectionEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000BC6 RID: 3014
		// (set) Token: 0x06000BC7 RID: 3015
		float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000BC8 RID: 3016
		// (set) Token: 0x06000BC9 RID: 3017
		float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000BCA RID: 3018
		// (set) Token: 0x06000BCB RID: 3019
		EdgeDetectionEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000BCC RID: 3020
		// (set) Token: 0x06000BCD RID: 3021
		bool OverlayEdges
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000BCE RID: 3022
		// (set) Token: 0x06000BCF RID: 3023
		CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000BD0 RID: 3024
		// (set) Token: 0x06000BD1 RID: 3025
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
