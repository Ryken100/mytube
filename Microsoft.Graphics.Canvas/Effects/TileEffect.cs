using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017D RID: 381
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class TileEffect : ITileEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000FE6 RID: 4070
		public extern TileEffect();

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000FE7 RID: 4071
		// (set) Token: 0x06000FE8 RID: 4072
		public extern Rect SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000FE9 RID: 4073
		// (set) Token: 0x06000FEA RID: 4074
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000FEB RID: 4075
		// (set) Token: 0x06000FEC RID: 4076
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000FED RID: 4077
		// (set) Token: 0x06000FEE RID: 4078
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FEF RID: 4079
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000FF0 RID: 4080
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000FF1 RID: 4081
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000FF2 RID: 4082
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000FF3 RID: 4083
		// (set) Token: 0x06000FF4 RID: 4084
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FF5 RID: 4085
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000FF6 RID: 4086
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000FF7 RID: 4087
		public extern void Close();
	}
}
