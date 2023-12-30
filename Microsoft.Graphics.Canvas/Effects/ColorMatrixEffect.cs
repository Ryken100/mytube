using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000121 RID: 289
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class ColorMatrixEffect : IColorMatrixEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x060009F8 RID: 2552
		public extern ColorMatrixEffect();

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060009F9 RID: 2553
		// (set) Token: 0x060009FA RID: 2554
		public extern Matrix5x4 ColorMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009FB RID: 2555
		// (set) Token: 0x060009FC RID: 2556
		public extern CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060009FD RID: 2557
		// (set) Token: 0x060009FE RID: 2558
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060009FF RID: 2559
		// (set) Token: 0x06000A00 RID: 2560
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000A01 RID: 2561
		// (set) Token: 0x06000A02 RID: 2562
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000A03 RID: 2563
		// (set) Token: 0x06000A04 RID: 2564
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A05 RID: 2565
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000A06 RID: 2566
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000A07 RID: 2567
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000A08 RID: 2568
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000A09 RID: 2569
		// (set) Token: 0x06000A0A RID: 2570
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A0B RID: 2571
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000A0C RID: 2572
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000A0D RID: 2573
		public extern void Close();
	}
}
