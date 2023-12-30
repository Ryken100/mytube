using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000149 RID: 329
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class HighlightsAndShadowsEffect : IHighlightsAndShadowsEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000CAE RID: 3246
		public extern HighlightsAndShadowsEffect();

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000CAF RID: 3247
		// (set) Token: 0x06000CB0 RID: 3248
		public extern float Highlights
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000CB1 RID: 3249
		// (set) Token: 0x06000CB2 RID: 3250
		public extern float Shadows
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000CB3 RID: 3251
		// (set) Token: 0x06000CB4 RID: 3252
		public extern float Clarity
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000CB5 RID: 3253
		// (set) Token: 0x06000CB6 RID: 3254
		public extern float MaskBlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000CB7 RID: 3255
		// (set) Token: 0x06000CB8 RID: 3256
		public extern bool SourceIsLinearGamma
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000CB9 RID: 3257
		// (set) Token: 0x06000CBA RID: 3258
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000CBB RID: 3259
		// (set) Token: 0x06000CBC RID: 3260
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000CBD RID: 3261
		// (set) Token: 0x06000CBE RID: 3262
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CBF RID: 3263
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000CC0 RID: 3264
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000CC1 RID: 3265
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000CC2 RID: 3266
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000CC3 RID: 3267
		// (set) Token: 0x06000CC4 RID: 3268
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000CC5 RID: 3269
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000CC6 RID: 3270
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000CC7 RID: 3271
		public extern void Close();
	}
}
