using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000153 RID: 339
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class LuminanceToAlphaEffect : ILuminanceToAlphaEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000D4E RID: 3406
		public extern LuminanceToAlphaEffect();

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D4F RID: 3407
		// (set) Token: 0x06000D50 RID: 3408
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D51 RID: 3409
		// (set) Token: 0x06000D52 RID: 3410
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D53 RID: 3411
		// (set) Token: 0x06000D54 RID: 3412
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D55 RID: 3413
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000D56 RID: 3414
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000D57 RID: 3415
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000D58 RID: 3416
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D59 RID: 3417
		// (set) Token: 0x06000D5A RID: 3418
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D5B RID: 3419
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000D5C RID: 3420
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000D5D RID: 3421
		public extern void Close();
	}
}
