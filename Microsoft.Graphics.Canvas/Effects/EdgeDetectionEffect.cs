using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200013D RID: 317
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class EdgeDetectionEffect : IEdgeDetectionEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000BD2 RID: 3026
		public extern EdgeDetectionEffect();

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000BD3 RID: 3027
		// (set) Token: 0x06000BD4 RID: 3028
		public extern float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000BD5 RID: 3029
		// (set) Token: 0x06000BD6 RID: 3030
		public extern float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000BD7 RID: 3031
		// (set) Token: 0x06000BD8 RID: 3032
		public extern EdgeDetectionEffectMode Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000BD9 RID: 3033
		// (set) Token: 0x06000BDA RID: 3034
		public extern bool OverlayEdges
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000BDB RID: 3035
		// (set) Token: 0x06000BDC RID: 3036
		public extern CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BDD RID: 3037
		// (set) Token: 0x06000BDE RID: 3038
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000BDF RID: 3039
		// (set) Token: 0x06000BE0 RID: 3040
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BE1 RID: 3041
		// (set) Token: 0x06000BE2 RID: 3042
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BE3 RID: 3043
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000BE4 RID: 3044
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000BE5 RID: 3045
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000BE6 RID: 3046
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000BE7 RID: 3047
		// (set) Token: 0x06000BE8 RID: 3048
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BE9 RID: 3049
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000BEA RID: 3050
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000BEB RID: 3051
		public extern void Close();
	}
}
