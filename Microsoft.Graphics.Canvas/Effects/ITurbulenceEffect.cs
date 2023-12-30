using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000186 RID: 390
	[Guid(481407805U, 8425, 22091, 133, 110, 55, 233, 250, 29, 0, 22)]
	[ExclusiveTo(typeof(TurbulenceEffect))]
	[Version(167772160U)]
	internal interface ITurbulenceEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001058 RID: 4184
		// (set) Token: 0x06001059 RID: 4185
		Vector2 Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600105A RID: 4186
		// (set) Token: 0x0600105B RID: 4187
		Vector2 Size
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600105C RID: 4188
		// (set) Token: 0x0600105D RID: 4189
		Vector2 Frequency
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600105E RID: 4190
		// (set) Token: 0x0600105F RID: 4191
		int Octaves
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001060 RID: 4192
		// (set) Token: 0x06001061 RID: 4193
		int Seed
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001062 RID: 4194
		// (set) Token: 0x06001063 RID: 4195
		TurbulenceEffectNoise Noise
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001064 RID: 4196
		// (set) Token: 0x06001065 RID: 4197
		bool Tileable
		{
			get; [param: In]
			set;
		}
	}
}
