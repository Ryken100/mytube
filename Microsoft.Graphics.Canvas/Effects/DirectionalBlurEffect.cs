using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000130 RID: 304
	[Version(167772160U)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class DirectionalBlurEffect : IDirectionalBlurEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000AD0 RID: 2768
		public extern DirectionalBlurEffect();

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000AD1 RID: 2769
		// (set) Token: 0x06000AD2 RID: 2770
		public extern float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000AD3 RID: 2771
		// (set) Token: 0x06000AD4 RID: 2772
		public extern float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000AD5 RID: 2773
		// (set) Token: 0x06000AD6 RID: 2774
		public extern EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000AD7 RID: 2775
		// (set) Token: 0x06000AD8 RID: 2776
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000AD9 RID: 2777
		// (set) Token: 0x06000ADA RID: 2778
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000ADB RID: 2779
		// (set) Token: 0x06000ADC RID: 2780
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000ADD RID: 2781
		// (set) Token: 0x06000ADE RID: 2782
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000ADF RID: 2783
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000AE0 RID: 2784
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000AE1 RID: 2785
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000AE2 RID: 2786
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000AE3 RID: 2787
		// (set) Token: 0x06000AE4 RID: 2788
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000AE5 RID: 2789
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000AE6 RID: 2790
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000AE7 RID: 2791
		public extern void Close();
	}
}
