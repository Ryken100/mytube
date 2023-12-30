using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012E RID: 302
	[MarshalingBehavior(2)]
	[Static(typeof(ICrossFadeEffectStatics), 167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	public sealed class CrossFadeEffect : ICrossFadeEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000AB1 RID: 2737
		public extern CrossFadeEffect();

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000AB2 RID: 2738
		// (set) Token: 0x06000AB3 RID: 2739
		public extern float CrossFade
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000AB4 RID: 2740
		// (set) Token: 0x06000AB5 RID: 2741
		public extern IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000AB6 RID: 2742
		// (set) Token: 0x06000AB7 RID: 2743
		public extern IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000AB8 RID: 2744
		// (set) Token: 0x06000AB9 RID: 2745
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000ABA RID: 2746
		// (set) Token: 0x06000ABB RID: 2747
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000ABC RID: 2748
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000ABD RID: 2749
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000ABE RID: 2750
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000ABF RID: 2751
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000AC0 RID: 2752
		// (set) Token: 0x06000AC1 RID: 2753
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000AC2 RID: 2754
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000AC3 RID: 2755
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000AC4 RID: 2756
		public extern void Close();

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000AC5 RID: 2757
		public static extern bool IsSupported { get; }
	}
}
