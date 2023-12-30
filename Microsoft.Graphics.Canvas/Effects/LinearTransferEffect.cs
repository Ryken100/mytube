using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000151 RID: 337
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class LinearTransferEffect : ILinearTransferEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000D22 RID: 3362
		public extern LinearTransferEffect();

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000D23 RID: 3363
		// (set) Token: 0x06000D24 RID: 3364
		public extern float RedOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D25 RID: 3365
		// (set) Token: 0x06000D26 RID: 3366
		public extern float RedSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000D27 RID: 3367
		// (set) Token: 0x06000D28 RID: 3368
		public extern bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D29 RID: 3369
		// (set) Token: 0x06000D2A RID: 3370
		public extern float GreenOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D2B RID: 3371
		// (set) Token: 0x06000D2C RID: 3372
		public extern float GreenSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D2D RID: 3373
		// (set) Token: 0x06000D2E RID: 3374
		public extern bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D2F RID: 3375
		// (set) Token: 0x06000D30 RID: 3376
		public extern float BlueOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D31 RID: 3377
		// (set) Token: 0x06000D32 RID: 3378
		public extern float BlueSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D33 RID: 3379
		// (set) Token: 0x06000D34 RID: 3380
		public extern bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D35 RID: 3381
		// (set) Token: 0x06000D36 RID: 3382
		public extern float AlphaOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D37 RID: 3383
		// (set) Token: 0x06000D38 RID: 3384
		public extern float AlphaSlope
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D39 RID: 3385
		// (set) Token: 0x06000D3A RID: 3386
		public extern bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D3B RID: 3387
		// (set) Token: 0x06000D3C RID: 3388
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D3D RID: 3389
		// (set) Token: 0x06000D3E RID: 3390
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D3F RID: 3391
		// (set) Token: 0x06000D40 RID: 3392
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D41 RID: 3393
		// (set) Token: 0x06000D42 RID: 3394
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D43 RID: 3395
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000D44 RID: 3396
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000D45 RID: 3397
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000D46 RID: 3398
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D47 RID: 3399
		// (set) Token: 0x06000D48 RID: 3400
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D49 RID: 3401
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000D4A RID: 3402
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000D4B RID: 3403
		public extern void Close();
	}
}
