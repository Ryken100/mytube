using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000136 RID: 310
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	public sealed class DistantDiffuseEffect : IDistantDiffuseEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000B52 RID: 2898
		public extern DistantDiffuseEffect();

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000B53 RID: 2899
		// (set) Token: 0x06000B54 RID: 2900
		public extern float Azimuth
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000B55 RID: 2901
		// (set) Token: 0x06000B56 RID: 2902
		public extern float Elevation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000B57 RID: 2903
		// (set) Token: 0x06000B58 RID: 2904
		public extern float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000B59 RID: 2905
		// (set) Token: 0x06000B5A RID: 2906
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000B5B RID: 2907
		// (set) Token: 0x06000B5C RID: 2908
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000B5D RID: 2909
		// (set) Token: 0x06000B5E RID: 2910
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000B5F RID: 2911
		// (set) Token: 0x06000B60 RID: 2912
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000B61 RID: 2913
		// (set) Token: 0x06000B62 RID: 2914
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000B63 RID: 2915
		// (set) Token: 0x06000B64 RID: 2916
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000B65 RID: 2917
		// (set) Token: 0x06000B66 RID: 2918
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000B67 RID: 2919
		// (set) Token: 0x06000B68 RID: 2920
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B69 RID: 2921
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000B6A RID: 2922
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000B6B RID: 2923
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000B6C RID: 2924
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000B6D RID: 2925
		// (set) Token: 0x06000B6E RID: 2926
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B6F RID: 2927
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000B70 RID: 2928
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000B71 RID: 2929
		public extern void Close();
	}
}
