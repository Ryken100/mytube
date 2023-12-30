using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015B RID: 347
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class OpacityMetadataEffect : IOpacityMetadataEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000D98 RID: 3480
		public extern OpacityMetadataEffect();

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000D99 RID: 3481
		// (set) Token: 0x06000D9A RID: 3482
		public extern Rect OpaqueRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D9B RID: 3483
		// (set) Token: 0x06000D9C RID: 3484
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D9D RID: 3485
		// (set) Token: 0x06000D9E RID: 3486
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D9F RID: 3487
		// (set) Token: 0x06000DA0 RID: 3488
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000DA1 RID: 3489
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000DA2 RID: 3490
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000DA3 RID: 3491
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000DA4 RID: 3492
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DA5 RID: 3493
		// (set) Token: 0x06000DA6 RID: 3494
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000DA7 RID: 3495
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000DA8 RID: 3496
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000DA9 RID: 3497
		public extern void Close();
	}
}
