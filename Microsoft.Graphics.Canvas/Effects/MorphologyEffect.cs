using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000156 RID: 342
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class MorphologyEffect : IMorphologyEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000D66 RID: 3430
		public extern MorphologyEffect();

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D67 RID: 3431
		// (set) Token: 0x06000D68 RID: 3432
		public extern MorphologyEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D69 RID: 3433
		// (set) Token: 0x06000D6A RID: 3434
		public extern int Width
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D6B RID: 3435
		// (set) Token: 0x06000D6C RID: 3436
		public extern int Height
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D6D RID: 3437
		// (set) Token: 0x06000D6E RID: 3438
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D6F RID: 3439
		// (set) Token: 0x06000D70 RID: 3440
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D71 RID: 3441
		// (set) Token: 0x06000D72 RID: 3442
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D73 RID: 3443
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000D74 RID: 3444
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000D75 RID: 3445
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000D76 RID: 3446
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D77 RID: 3447
		// (set) Token: 0x06000D78 RID: 3448
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D79 RID: 3449
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000D7A RID: 3450
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000D7B RID: 3451
		public extern void Close();
	}
}
