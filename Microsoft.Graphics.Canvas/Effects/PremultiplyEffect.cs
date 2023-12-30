using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000163 RID: 355
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class PremultiplyEffect : IPremultiplyEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E2A RID: 3626
		public extern PremultiplyEffect();

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000E2B RID: 3627
		// (set) Token: 0x06000E2C RID: 3628
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000E2D RID: 3629
		// (set) Token: 0x06000E2E RID: 3630
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000E2F RID: 3631
		// (set) Token: 0x06000E30 RID: 3632
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E31 RID: 3633
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E32 RID: 3634
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E33 RID: 3635
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E34 RID: 3636
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000E35 RID: 3637
		// (set) Token: 0x06000E36 RID: 3638
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E37 RID: 3639
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E38 RID: 3640
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E39 RID: 3641
		public extern void Close();
	}
}
