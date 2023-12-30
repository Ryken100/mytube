using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200016B RID: 363
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class SepiaEffect : ISepiaEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E92 RID: 3730
		public extern SepiaEffect();

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000E93 RID: 3731
		// (set) Token: 0x06000E94 RID: 3732
		public extern float Intensity
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000E95 RID: 3733
		// (set) Token: 0x06000E96 RID: 3734
		public extern CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000E97 RID: 3735
		// (set) Token: 0x06000E98 RID: 3736
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000E99 RID: 3737
		// (set) Token: 0x06000E9A RID: 3738
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000E9B RID: 3739
		// (set) Token: 0x06000E9C RID: 3740
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E9D RID: 3741
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E9E RID: 3742
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E9F RID: 3743
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000EA0 RID: 3744
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000EA1 RID: 3745
		// (set) Token: 0x06000EA2 RID: 3746
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000EA3 RID: 3747
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000EA4 RID: 3748
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000EA5 RID: 3749
		public extern void Close();
	}
}
