using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000129 RID: 297
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class ConvolveMatrixEffect : IConvolveMatrixEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000A6A RID: 2666
		public extern ConvolveMatrixEffect();

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000A6B RID: 2667
		// (set) Token: 0x06000A6C RID: 2668
		public extern Vector2 KernelScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000A6D RID: 2669
		// (set) Token: 0x06000A6E RID: 2670
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000A6F RID: 2671
		// (set) Token: 0x06000A70 RID: 2672
		public extern int KernelWidth
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000A71 RID: 2673
		// (set) Token: 0x06000A72 RID: 2674
		public extern int KernelHeight
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000A73 RID: 2675
		// (set) Token: 0x06000A74 RID: 2676
		public extern float[] KernelMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000A75 RID: 2677
		// (set) Token: 0x06000A76 RID: 2678
		public extern float Divisor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000A77 RID: 2679
		// (set) Token: 0x06000A78 RID: 2680
		public extern float Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000A79 RID: 2681
		// (set) Token: 0x06000A7A RID: 2682
		public extern Vector2 KernelOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000A7B RID: 2683
		// (set) Token: 0x06000A7C RID: 2684
		public extern bool PreserveAlpha
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000A7D RID: 2685
		// (set) Token: 0x06000A7E RID: 2686
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000A7F RID: 2687
		// (set) Token: 0x06000A80 RID: 2688
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000A81 RID: 2689
		// (set) Token: 0x06000A82 RID: 2690
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000A83 RID: 2691
		// (set) Token: 0x06000A84 RID: 2692
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000A85 RID: 2693
		// (set) Token: 0x06000A86 RID: 2694
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A87 RID: 2695
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000A88 RID: 2696
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000A89 RID: 2697
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000A8A RID: 2698
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000A8B RID: 2699
		// (set) Token: 0x06000A8C RID: 2700
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A8D RID: 2701
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000A8E RID: 2702
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000A8F RID: 2703
		public extern void Close();
	}
}
