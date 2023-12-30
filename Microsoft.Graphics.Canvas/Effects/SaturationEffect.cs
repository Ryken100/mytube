using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000167 RID: 359
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class SaturationEffect : ISaturationEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E54 RID: 3668
		public extern SaturationEffect();

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000E55 RID: 3669
		// (set) Token: 0x06000E56 RID: 3670
		public extern float Saturation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000E57 RID: 3671
		// (set) Token: 0x06000E58 RID: 3672
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000E59 RID: 3673
		// (set) Token: 0x06000E5A RID: 3674
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000E5B RID: 3675
		// (set) Token: 0x06000E5C RID: 3676
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E5D RID: 3677
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E5E RID: 3678
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E5F RID: 3679
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E60 RID: 3680
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000E61 RID: 3681
		// (set) Token: 0x06000E62 RID: 3682
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E63 RID: 3683
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E64 RID: 3684
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E65 RID: 3685
		public extern void Close();
	}
}
