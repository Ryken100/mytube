using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000169 RID: 361
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class ScaleEffect : IScaleEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E72 RID: 3698
		public extern ScaleEffect();

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000E73 RID: 3699
		// (set) Token: 0x06000E74 RID: 3700
		public extern Vector2 Scale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000E75 RID: 3701
		// (set) Token: 0x06000E76 RID: 3702
		public extern Vector2 CenterPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000E77 RID: 3703
		// (set) Token: 0x06000E78 RID: 3704
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000E79 RID: 3705
		// (set) Token: 0x06000E7A RID: 3706
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000E7B RID: 3707
		// (set) Token: 0x06000E7C RID: 3708
		public extern float Sharpness
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000E7D RID: 3709
		// (set) Token: 0x06000E7E RID: 3710
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000E7F RID: 3711
		// (set) Token: 0x06000E80 RID: 3712
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000E81 RID: 3713
		// (set) Token: 0x06000E82 RID: 3714
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E83 RID: 3715
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E84 RID: 3716
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E85 RID: 3717
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E86 RID: 3718
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000E87 RID: 3719
		// (set) Token: 0x06000E88 RID: 3720
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E89 RID: 3721
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E8A RID: 3722
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E8B RID: 3723
		public extern void Close();
	}
}
