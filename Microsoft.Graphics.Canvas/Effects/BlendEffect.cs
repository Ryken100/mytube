using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000115 RID: 277
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class BlendEffect : IBlendEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000956 RID: 2390
		public extern BlendEffect();

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000957 RID: 2391
		// (set) Token: 0x06000958 RID: 2392
		public extern BlendEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000959 RID: 2393
		// (set) Token: 0x0600095A RID: 2394
		public extern IGraphicsEffectSource Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600095B RID: 2395
		// (set) Token: 0x0600095C RID: 2396
		public extern IGraphicsEffectSource Foreground
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600095D RID: 2397
		// (set) Token: 0x0600095E RID: 2398
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600095F RID: 2399
		// (set) Token: 0x06000960 RID: 2400
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000961 RID: 2401
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000962 RID: 2402
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000963 RID: 2403
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000964 RID: 2404
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000965 RID: 2405
		// (set) Token: 0x06000966 RID: 2406
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000967 RID: 2407
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000968 RID: 2408
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000969 RID: 2409
		public extern void Close();
	}
}
