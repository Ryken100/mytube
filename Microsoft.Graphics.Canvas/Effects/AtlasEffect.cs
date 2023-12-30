using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000112 RID: 274
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class AtlasEffect : IAtlasEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x0600093C RID: 2364
		public extern AtlasEffect();

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600093D RID: 2365
		// (set) Token: 0x0600093E RID: 2366
		public extern Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600093F RID: 2367
		// (set) Token: 0x06000940 RID: 2368
		public extern Rect PaddingRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000941 RID: 2369
		// (set) Token: 0x06000942 RID: 2370
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000943 RID: 2371
		// (set) Token: 0x06000944 RID: 2372
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000945 RID: 2373
		// (set) Token: 0x06000946 RID: 2374
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000947 RID: 2375
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000948 RID: 2376
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000949 RID: 2377
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x0600094A RID: 2378
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600094B RID: 2379
		// (set) Token: 0x0600094C RID: 2380
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600094D RID: 2381
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x0600094E RID: 2382
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x0600094F RID: 2383
		public extern void Close();
	}
}
