using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000150 RID: 336
	[ExclusiveTo(typeof(LinearTransferEffect))]
	[Guid(1137867472U, 35127, 24539, 135, 106, 78, 145, 203, 71, 84, 12)]
	[Version(167772160U)]
	internal interface ILinearTransferEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000D06 RID: 3334
		// (set) Token: 0x06000D07 RID: 3335
		float RedOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000D08 RID: 3336
		// (set) Token: 0x06000D09 RID: 3337
		float RedSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000D0A RID: 3338
		// (set) Token: 0x06000D0B RID: 3339
		bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000D0C RID: 3340
		// (set) Token: 0x06000D0D RID: 3341
		float GreenOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000D0E RID: 3342
		// (set) Token: 0x06000D0F RID: 3343
		float GreenSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000D10 RID: 3344
		// (set) Token: 0x06000D11 RID: 3345
		bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000D12 RID: 3346
		// (set) Token: 0x06000D13 RID: 3347
		float BlueOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000D14 RID: 3348
		// (set) Token: 0x06000D15 RID: 3349
		float BlueSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000D16 RID: 3350
		// (set) Token: 0x06000D17 RID: 3351
		bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000D18 RID: 3352
		// (set) Token: 0x06000D19 RID: 3353
		float AlphaOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000D1A RID: 3354
		// (set) Token: 0x06000D1B RID: 3355
		float AlphaSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000D1C RID: 3356
		// (set) Token: 0x06000D1D RID: 3357
		bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000D1E RID: 3358
		// (set) Token: 0x06000D1F RID: 3359
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000D20 RID: 3360
		// (set) Token: 0x06000D21 RID: 3361
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
