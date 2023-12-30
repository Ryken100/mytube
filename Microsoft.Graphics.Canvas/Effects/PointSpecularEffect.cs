using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015F RID: 351
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class PointSpecularEffect : IPointSpecularEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000DEA RID: 3562
		public extern PointSpecularEffect();

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000DEB RID: 3563
		// (set) Token: 0x06000DEC RID: 3564
		public extern Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000DED RID: 3565
		// (set) Token: 0x06000DEE RID: 3566
		public extern float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000DEF RID: 3567
		// (set) Token: 0x06000DF0 RID: 3568
		public extern float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000DF1 RID: 3569
		// (set) Token: 0x06000DF2 RID: 3570
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000DF3 RID: 3571
		// (set) Token: 0x06000DF4 RID: 3572
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000DF5 RID: 3573
		// (set) Token: 0x06000DF6 RID: 3574
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000DF7 RID: 3575
		// (set) Token: 0x06000DF8 RID: 3576
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000DF9 RID: 3577
		// (set) Token: 0x06000DFA RID: 3578
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000DFB RID: 3579
		// (set) Token: 0x06000DFC RID: 3580
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000DFD RID: 3581
		// (set) Token: 0x06000DFE RID: 3582
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000DFF RID: 3583
		// (set) Token: 0x06000E00 RID: 3584
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E01 RID: 3585
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E02 RID: 3586
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E03 RID: 3587
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E04 RID: 3588
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E05 RID: 3589
		// (set) Token: 0x06000E06 RID: 3590
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E07 RID: 3591
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E08 RID: 3592
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E09 RID: 3593
		public extern void Close();
	}
}
