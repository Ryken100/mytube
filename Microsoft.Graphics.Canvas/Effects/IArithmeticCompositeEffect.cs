using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010F RID: 271
	[ExclusiveTo(typeof(ArithmeticCompositeEffect))]
	[Version(167772160U)]
	[Guid(3203098667U, 54860, 23691, 161, 251, 51, 33, 98, 237, 9, 156)]
	internal interface IArithmeticCompositeEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600090C RID: 2316
		// (set) Token: 0x0600090D RID: 2317
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600090E RID: 2318
		// (set) Token: 0x0600090F RID: 2319
		float MultiplyAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000910 RID: 2320
		// (set) Token: 0x06000911 RID: 2321
		float Source1Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000912 RID: 2322
		// (set) Token: 0x06000913 RID: 2323
		float Source2Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000914 RID: 2324
		// (set) Token: 0x06000915 RID: 2325
		float Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000916 RID: 2326
		// (set) Token: 0x06000917 RID: 2327
		IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000918 RID: 2328
		// (set) Token: 0x06000919 RID: 2329
		IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}
	}
}
