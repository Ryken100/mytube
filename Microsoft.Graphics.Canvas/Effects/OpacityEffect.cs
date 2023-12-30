using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000159 RID: 345
	[Activatable(167772160U)]
	[Static(typeof(IOpacityEffectStatics), 167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class OpacityEffect : IOpacityEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000D81 RID: 3457
		public extern OpacityEffect();

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D82 RID: 3458
		// (set) Token: 0x06000D83 RID: 3459
		public extern float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D84 RID: 3460
		// (set) Token: 0x06000D85 RID: 3461
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D86 RID: 3462
		// (set) Token: 0x06000D87 RID: 3463
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D88 RID: 3464
		// (set) Token: 0x06000D89 RID: 3465
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D8A RID: 3466
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000D8B RID: 3467
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000D8C RID: 3468
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000D8D RID: 3469
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D8E RID: 3470
		// (set) Token: 0x06000D8F RID: 3471
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000D90 RID: 3472
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000D91 RID: 3473
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000D92 RID: 3474
		public extern void Close();

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D93 RID: 3475
		public static extern bool IsSupported { get; }
	}
}
