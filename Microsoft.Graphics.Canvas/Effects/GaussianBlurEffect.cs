using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000145 RID: 325
	[Version(167772160U)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class GaussianBlurEffect : IGaussianBlurEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000C7A RID: 3194
		public extern GaussianBlurEffect();

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000C7B RID: 3195
		// (set) Token: 0x06000C7C RID: 3196
		public extern float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000C7D RID: 3197
		// (set) Token: 0x06000C7E RID: 3198
		public extern EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000C7F RID: 3199
		// (set) Token: 0x06000C80 RID: 3200
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000C81 RID: 3201
		// (set) Token: 0x06000C82 RID: 3202
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000C83 RID: 3203
		// (set) Token: 0x06000C84 RID: 3204
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000C85 RID: 3205
		// (set) Token: 0x06000C86 RID: 3206
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C87 RID: 3207
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000C88 RID: 3208
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000C89 RID: 3209
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000C8A RID: 3210
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000C8B RID: 3211
		// (set) Token: 0x06000C8C RID: 3212
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C8D RID: 3213
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000C8E RID: 3214
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000C8F RID: 3215
		public extern void Close();
	}
}
