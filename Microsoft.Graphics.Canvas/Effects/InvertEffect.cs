using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014F RID: 335
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class InvertEffect : IInvertEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000CF6 RID: 3318
		public extern InvertEffect();

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000CF7 RID: 3319
		// (set) Token: 0x06000CF8 RID: 3320
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000CF9 RID: 3321
		// (set) Token: 0x06000CFA RID: 3322
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000CFB RID: 3323
		// (set) Token: 0x06000CFC RID: 3324
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CFD RID: 3325
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000CFE RID: 3326
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000CFF RID: 3327
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000D00 RID: 3328
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000D01 RID: 3329
		// (set) Token: 0x06000D02 RID: 3330
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D03 RID: 3331
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000D04 RID: 3332
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000D05 RID: 3333
		public extern void Close();
	}
}
