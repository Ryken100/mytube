using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015D RID: 349
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class PointDiffuseEffect : IPointDiffuseEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000DBA RID: 3514
		public extern PointDiffuseEffect();

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000DBB RID: 3515
		// (set) Token: 0x06000DBC RID: 3516
		public extern Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000DBD RID: 3517
		// (set) Token: 0x06000DBE RID: 3518
		public extern float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000DBF RID: 3519
		// (set) Token: 0x06000DC0 RID: 3520
		public extern float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000DC1 RID: 3521
		// (set) Token: 0x06000DC2 RID: 3522
		public extern Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000DC3 RID: 3523
		// (set) Token: 0x06000DC4 RID: 3524
		public extern Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000DC5 RID: 3525
		// (set) Token: 0x06000DC6 RID: 3526
		public extern CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000DC7 RID: 3527
		// (set) Token: 0x06000DC8 RID: 3528
		public extern Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000DC9 RID: 3529
		// (set) Token: 0x06000DCA RID: 3530
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000DCB RID: 3531
		// (set) Token: 0x06000DCC RID: 3532
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000DCD RID: 3533
		// (set) Token: 0x06000DCE RID: 3534
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000DCF RID: 3535
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000DD0 RID: 3536
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000DD1 RID: 3537
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000DD2 RID: 3538
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000DD3 RID: 3539
		// (set) Token: 0x06000DD4 RID: 3540
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000DD5 RID: 3541
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000DD6 RID: 3542
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000DD7 RID: 3543
		public extern void Close();
	}
}
