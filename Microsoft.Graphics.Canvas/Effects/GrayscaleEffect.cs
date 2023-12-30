using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000147 RID: 327
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class GrayscaleEffect : IGrayscaleEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000C92 RID: 3218
		public extern GrayscaleEffect();

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000C93 RID: 3219
		// (set) Token: 0x06000C94 RID: 3220
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000C95 RID: 3221
		// (set) Token: 0x06000C96 RID: 3222
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000C97 RID: 3223
		// (set) Token: 0x06000C98 RID: 3224
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C99 RID: 3225
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000C9A RID: 3226
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000C9B RID: 3227
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000C9C RID: 3228
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000C9D RID: 3229
		// (set) Token: 0x06000C9E RID: 3230
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C9F RID: 3231
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000CA0 RID: 3232
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000CA1 RID: 3233
		public extern void Close();
	}
}
