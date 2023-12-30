using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000138 RID: 312
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class DistantSpecularEffect : IDistantSpecularEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000B86 RID: 2950
		public extern DistantSpecularEffect();

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B87 RID: 2951
		// (set) Token: 0x06000B88 RID: 2952
		public extern float Azimuth
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000B89 RID: 2953
		// (set) Token: 0x06000B8A RID: 2954
		public extern float Elevation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000B8B RID: 2955
		// (set) Token: 0x06000B8C RID: 2956
		public extern float SpecularExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000B8D RID: 2957
		// (set) Token: 0x06000B8E RID: 2958
		public extern float SpecularAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000B8F RID: 2959
		// (set) Token: 0x06000B90 RID: 2960
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000B91 RID: 2961
		// (set) Token: 0x06000B92 RID: 2962
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000B93 RID: 2963
		// (set) Token: 0x06000B94 RID: 2964
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000B95 RID: 2965
		// (set) Token: 0x06000B96 RID: 2966
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000B97 RID: 2967
		// (set) Token: 0x06000B98 RID: 2968
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000B99 RID: 2969
		// (set) Token: 0x06000B9A RID: 2970
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000B9B RID: 2971
		// (set) Token: 0x06000B9C RID: 2972
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000B9D RID: 2973
		// (set) Token: 0x06000B9E RID: 2974
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B9F RID: 2975
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000BA0 RID: 2976
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000BA1 RID: 2977
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000BA2 RID: 2978
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000BA3 RID: 2979
		// (set) Token: 0x06000BA4 RID: 2980
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BA5 RID: 2981
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000BA6 RID: 2982
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000BA7 RID: 2983
		public extern void Close();
	}
}
