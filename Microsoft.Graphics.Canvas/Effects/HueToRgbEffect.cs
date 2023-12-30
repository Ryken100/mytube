using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014D RID: 333
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Activatable(167772160U)]
	public sealed class HueToRgbEffect : IHueToRgbEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000CE2 RID: 3298
		public extern HueToRgbEffect();

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000CE3 RID: 3299
		// (set) Token: 0x06000CE4 RID: 3300
		public extern EffectHueColorSpace SourceColorSpace
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000CE5 RID: 3301
		// (set) Token: 0x06000CE6 RID: 3302
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000CE7 RID: 3303
		// (set) Token: 0x06000CE8 RID: 3304
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000CE9 RID: 3305
		// (set) Token: 0x06000CEA RID: 3306
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CEB RID: 3307
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000CEC RID: 3308
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000CED RID: 3309
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000CEE RID: 3310
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000CEF RID: 3311
		// (set) Token: 0x06000CF0 RID: 3312
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CF1 RID: 3313
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000CF2 RID: 3314
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000CF3 RID: 3315
		public extern void Close();
	}
}
