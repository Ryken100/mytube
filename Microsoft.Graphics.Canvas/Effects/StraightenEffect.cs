using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000175 RID: 373
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class StraightenEffect : IStraightenEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000F62 RID: 3938
		public extern StraightenEffect();

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000F63 RID: 3939
		// (set) Token: 0x06000F64 RID: 3940
		public extern float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000F65 RID: 3941
		// (set) Token: 0x06000F66 RID: 3942
		public extern bool MaintainSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000F67 RID: 3943
		// (set) Token: 0x06000F68 RID: 3944
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000F69 RID: 3945
		// (set) Token: 0x06000F6A RID: 3946
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000F6B RID: 3947
		// (set) Token: 0x06000F6C RID: 3948
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000F6D RID: 3949
		// (set) Token: 0x06000F6E RID: 3950
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F6F RID: 3951
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000F70 RID: 3952
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000F71 RID: 3953
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000F72 RID: 3954
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000F73 RID: 3955
		// (set) Token: 0x06000F74 RID: 3956
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000F75 RID: 3957
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000F76 RID: 3958
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000F77 RID: 3959
		public extern void Close();
	}
}
