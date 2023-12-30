using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000171 RID: 369
	[Activatable(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class SpotDiffuseEffect : ISpotDiffuseEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000EF8 RID: 3832
		public extern SpotDiffuseEffect();

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000EF9 RID: 3833
		// (set) Token: 0x06000EFA RID: 3834
		public extern Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000EFB RID: 3835
		// (set) Token: 0x06000EFC RID: 3836
		public extern Vector3 LightTarget
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000EFD RID: 3837
		// (set) Token: 0x06000EFE RID: 3838
		public extern float Focus
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000EFF RID: 3839
		// (set) Token: 0x06000F00 RID: 3840
		public extern float LimitingConeAngle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000F01 RID: 3841
		// (set) Token: 0x06000F02 RID: 3842
		public extern float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F03 RID: 3843
		// (set) Token: 0x06000F04 RID: 3844
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000F05 RID: 3845
		// (set) Token: 0x06000F06 RID: 3846
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F07 RID: 3847
		// (set) Token: 0x06000F08 RID: 3848
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000F09 RID: 3849
		// (set) Token: 0x06000F0A RID: 3850
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F0B RID: 3851
		// (set) Token: 0x06000F0C RID: 3852
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000F0D RID: 3853
		// (set) Token: 0x06000F0E RID: 3854
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F0F RID: 3855
		// (set) Token: 0x06000F10 RID: 3856
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F11 RID: 3857
		// (set) Token: 0x06000F12 RID: 3858
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F13 RID: 3859
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000F14 RID: 3860
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000F15 RID: 3861
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000F16 RID: 3862
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000F17 RID: 3863
		// (set) Token: 0x06000F18 RID: 3864
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F19 RID: 3865
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000F1A RID: 3866
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000F1B RID: 3867
		public extern void Close();
	}
}
