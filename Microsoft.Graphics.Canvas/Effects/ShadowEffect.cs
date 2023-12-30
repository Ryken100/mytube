using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016D RID: 365
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class ShadowEffect : IShadowEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000EB0 RID: 3760
		public extern ShadowEffect();

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000EB1 RID: 3761
		// (set) Token: 0x06000EB2 RID: 3762
		public extern float BlurAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000EB3 RID: 3763
		// (set) Token: 0x06000EB4 RID: 3764
		public extern Color ShadowColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000EB5 RID: 3765
		// (set) Token: 0x06000EB6 RID: 3766
		public extern EffectOptimization Optimization
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000EB7 RID: 3767
		// (set) Token: 0x06000EB8 RID: 3768
		public extern Vector4 ShadowColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000EB9 RID: 3769
		// (set) Token: 0x06000EBA RID: 3770
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000EBB RID: 3771
		// (set) Token: 0x06000EBC RID: 3772
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000EBD RID: 3773
		// (set) Token: 0x06000EBE RID: 3774
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000EBF RID: 3775
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000EC0 RID: 3776
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000EC1 RID: 3777
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000EC2 RID: 3778
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000EC3 RID: 3779
		// (set) Token: 0x06000EC4 RID: 3780
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000EC5 RID: 3781
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000EC6 RID: 3782
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000EC7 RID: 3783
		public extern void Close();
	}
}
