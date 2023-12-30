using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000117 RID: 279
	[Threading(3)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class BorderEffect : IBorderEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000970 RID: 2416
		public extern BorderEffect();

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000971 RID: 2417
		// (set) Token: 0x06000972 RID: 2418
		public extern CanvasEdgeBehavior ExtendX
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000973 RID: 2419
		// (set) Token: 0x06000974 RID: 2420
		public extern CanvasEdgeBehavior ExtendY
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000975 RID: 2421
		// (set) Token: 0x06000976 RID: 2422
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000977 RID: 2423
		// (set) Token: 0x06000978 RID: 2424
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000979 RID: 2425
		// (set) Token: 0x0600097A RID: 2426
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600097B RID: 2427
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x0600097C RID: 2428
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x0600097D RID: 2429
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x0600097E RID: 2430
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600097F RID: 2431
		// (set) Token: 0x06000980 RID: 2432
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000981 RID: 2433
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000982 RID: 2434
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000983 RID: 2435
		public extern void Close();
	}
}
