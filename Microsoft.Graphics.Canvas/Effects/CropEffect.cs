using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012B RID: 299
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class CropEffect : ICropEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000A96 RID: 2710
		public extern CropEffect();

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000A97 RID: 2711
		// (set) Token: 0x06000A98 RID: 2712
		public extern Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000A99 RID: 2713
		// (set) Token: 0x06000A9A RID: 2714
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000A9B RID: 2715
		// (set) Token: 0x06000A9C RID: 2716
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000A9D RID: 2717
		// (set) Token: 0x06000A9E RID: 2718
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000A9F RID: 2719
		// (set) Token: 0x06000AA0 RID: 2720
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000AA1 RID: 2721
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000AA2 RID: 2722
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000AA3 RID: 2723
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000AA4 RID: 2724
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000AA5 RID: 2725
		// (set) Token: 0x06000AA6 RID: 2726
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000AA7 RID: 2727
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000AA8 RID: 2728
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000AA9 RID: 2729
		public extern void Close();
	}
}
