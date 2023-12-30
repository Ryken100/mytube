using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000123 RID: 291
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class ColorSourceEffect : IColorSourceEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000A12 RID: 2578
		public extern ColorSourceEffect();

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000A13 RID: 2579
		// (set) Token: 0x06000A14 RID: 2580
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000A15 RID: 2581
		// (set) Token: 0x06000A16 RID: 2582
		public extern Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000A17 RID: 2583
		// (set) Token: 0x06000A18 RID: 2584
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000A19 RID: 2585
		// (set) Token: 0x06000A1A RID: 2586
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A1B RID: 2587
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000A1C RID: 2588
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000A1D RID: 2589
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000A1E RID: 2590
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000A1F RID: 2591
		// (set) Token: 0x06000A20 RID: 2592
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A21 RID: 2593
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000A22 RID: 2594
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000A23 RID: 2595
		public extern void Close();
	}
}
