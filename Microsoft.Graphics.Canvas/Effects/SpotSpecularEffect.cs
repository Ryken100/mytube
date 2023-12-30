using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000173 RID: 371
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class SpotSpecularEffect : ISpotSpecularEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000F34 RID: 3892
		public extern SpotSpecularEffect();

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000F35 RID: 3893
		// (set) Token: 0x06000F36 RID: 3894
		public extern Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000F37 RID: 3895
		// (set) Token: 0x06000F38 RID: 3896
		public extern Vector3 LightTarget
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000F39 RID: 3897
		// (set) Token: 0x06000F3A RID: 3898
		public extern float Focus
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000F3B RID: 3899
		// (set) Token: 0x06000F3C RID: 3900
		public extern float LimitingConeAngle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000F3D RID: 3901
		// (set) Token: 0x06000F3E RID: 3902
		public extern float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000F3F RID: 3903
		// (set) Token: 0x06000F40 RID: 3904
		public extern float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000F41 RID: 3905
		// (set) Token: 0x06000F42 RID: 3906
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000F43 RID: 3907
		// (set) Token: 0x06000F44 RID: 3908
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000F45 RID: 3909
		// (set) Token: 0x06000F46 RID: 3910
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000F47 RID: 3911
		// (set) Token: 0x06000F48 RID: 3912
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000F49 RID: 3913
		// (set) Token: 0x06000F4A RID: 3914
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000F4B RID: 3915
		// (set) Token: 0x06000F4C RID: 3916
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000F4D RID: 3917
		// (set) Token: 0x06000F4E RID: 3918
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000F4F RID: 3919
		// (set) Token: 0x06000F50 RID: 3920
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F51 RID: 3921
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000F52 RID: 3922
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000F53 RID: 3923
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000F54 RID: 3924
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000F55 RID: 3925
		// (set) Token: 0x06000F56 RID: 3926
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F57 RID: 3927
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000F58 RID: 3928
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000F59 RID: 3929
		public extern void Close();
	}
}
