using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014B RID: 331
	[Activatable(167772160U)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class HueRotationEffect : IHueRotationEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000CCC RID: 3276
		public extern HueRotationEffect();

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000CCD RID: 3277
		// (set) Token: 0x06000CCE RID: 3278
		public extern float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000CCF RID: 3279
		// (set) Token: 0x06000CD0 RID: 3280
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000CD1 RID: 3281
		// (set) Token: 0x06000CD2 RID: 3282
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000CD3 RID: 3283
		// (set) Token: 0x06000CD4 RID: 3284
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CD5 RID: 3285
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000CD6 RID: 3286
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000CD7 RID: 3287
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000CD8 RID: 3288
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000CD9 RID: 3289
		// (set) Token: 0x06000CDA RID: 3290
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CDB RID: 3291
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000CDC RID: 3292
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000CDD RID: 3293
		public extern void Close();
	}
}
