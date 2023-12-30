using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016F RID: 367
	[Version(167772160U)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class SharpenEffect : ISharpenEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000ECE RID: 3790
		public extern SharpenEffect();

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000ECF RID: 3791
		// (set) Token: 0x06000ED0 RID: 3792
		public extern float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000ED1 RID: 3793
		// (set) Token: 0x06000ED2 RID: 3794
		public extern float Threshold
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000ED3 RID: 3795
		// (set) Token: 0x06000ED4 RID: 3796
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000ED5 RID: 3797
		// (set) Token: 0x06000ED6 RID: 3798
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000ED7 RID: 3799
		// (set) Token: 0x06000ED8 RID: 3800
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000ED9 RID: 3801
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000EDA RID: 3802
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000EDB RID: 3803
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000EDC RID: 3804
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000EDD RID: 3805
		// (set) Token: 0x06000EDE RID: 3806
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000EDF RID: 3807
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000EE0 RID: 3808
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000EE1 RID: 3809
		public extern void Close();
	}
}
