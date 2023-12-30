using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200011B RID: 283
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class ChromaKeyEffect : IChromaKeyEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x060009AA RID: 2474
		public extern ChromaKeyEffect();

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060009AB RID: 2475
		// (set) Token: 0x060009AC RID: 2476
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060009AD RID: 2477
		// (set) Token: 0x060009AE RID: 2478
		public extern float Tolerance
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060009AF RID: 2479
		// (set) Token: 0x060009B0 RID: 2480
		public extern bool InvertAlpha
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060009B1 RID: 2481
		// (set) Token: 0x060009B2 RID: 2482
		public extern bool Feather
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060009B3 RID: 2483
		// (set) Token: 0x060009B4 RID: 2484
		public extern Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060009B5 RID: 2485
		// (set) Token: 0x060009B6 RID: 2486
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060009B7 RID: 2487
		// (set) Token: 0x060009B8 RID: 2488
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060009B9 RID: 2489
		// (set) Token: 0x060009BA RID: 2490
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x060009BB RID: 2491
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x060009BC RID: 2492
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x060009BD RID: 2493
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x060009BE RID: 2494
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060009BF RID: 2495
		// (set) Token: 0x060009C0 RID: 2496
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x060009C1 RID: 2497
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x060009C2 RID: 2498
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x060009C3 RID: 2499
		public extern void Close();
	}
}
