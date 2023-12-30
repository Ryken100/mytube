using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000127 RID: 295
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class ContrastEffect : IContrastEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000A3E RID: 2622
		public extern ContrastEffect();

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000A3F RID: 2623
		// (set) Token: 0x06000A40 RID: 2624
		public extern float Contrast
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000A41 RID: 2625
		// (set) Token: 0x06000A42 RID: 2626
		public extern bool ClampSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000A43 RID: 2627
		// (set) Token: 0x06000A44 RID: 2628
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000A45 RID: 2629
		// (set) Token: 0x06000A46 RID: 2630
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000A47 RID: 2631
		// (set) Token: 0x06000A48 RID: 2632
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A49 RID: 2633
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000A4A RID: 2634
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000A4B RID: 2635
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000A4C RID: 2636
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000A4D RID: 2637
		// (set) Token: 0x06000A4E RID: 2638
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A4F RID: 2639
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000A50 RID: 2640
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000A51 RID: 2641
		public extern void Close();
	}
}
