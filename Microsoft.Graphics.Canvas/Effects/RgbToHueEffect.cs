using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000165 RID: 357
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class RgbToHueEffect : IRgbToHueEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E3E RID: 3646
		public extern RgbToHueEffect();

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000E3F RID: 3647
		// (set) Token: 0x06000E40 RID: 3648
		public extern EffectHueColorSpace OutputColorSpace
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000E41 RID: 3649
		// (set) Token: 0x06000E42 RID: 3650
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000E43 RID: 3651
		// (set) Token: 0x06000E44 RID: 3652
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000E45 RID: 3653
		// (set) Token: 0x06000E46 RID: 3654
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E47 RID: 3655
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E48 RID: 3656
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E49 RID: 3657
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E4A RID: 3658
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000E4B RID: 3659
		// (set) Token: 0x06000E4C RID: 3660
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E4D RID: 3661
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E4E RID: 3662
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E4F RID: 3663
		public extern void Close();
	}
}
