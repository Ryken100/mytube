using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200011F RID: 287
	[Threading(3)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Static(typeof(IColorManagementEffectStatics), 167772160U)]
	[MarshalingBehavior(2)]
	public sealed class ColorManagementEffect : IColorManagementEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x060009D3 RID: 2515
		public extern ColorManagementEffect();

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060009D4 RID: 2516
		// (set) Token: 0x060009D5 RID: 2517
		public extern ColorManagementProfile SourceColorProfile
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060009D6 RID: 2518
		// (set) Token: 0x060009D7 RID: 2519
		public extern ColorManagementRenderingIntent SourceRenderingIntent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060009D8 RID: 2520
		// (set) Token: 0x060009D9 RID: 2521
		public extern ColorManagementProfile OutputColorProfile
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060009DA RID: 2522
		// (set) Token: 0x060009DB RID: 2523
		public extern ColorManagementRenderingIntent OutputRenderingIntent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060009DC RID: 2524
		// (set) Token: 0x060009DD RID: 2525
		public extern CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060009DE RID: 2526
		// (set) Token: 0x060009DF RID: 2527
		public extern ColorManagementEffectQuality Quality
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060009E0 RID: 2528
		// (set) Token: 0x060009E1 RID: 2529
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060009E2 RID: 2530
		// (set) Token: 0x060009E3 RID: 2531
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060009E4 RID: 2532
		// (set) Token: 0x060009E5 RID: 2533
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x060009E6 RID: 2534
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x060009E7 RID: 2535
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x060009E8 RID: 2536
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x060009E9 RID: 2537
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060009EA RID: 2538
		// (set) Token: 0x060009EB RID: 2539
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x060009EC RID: 2540
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x060009ED RID: 2541
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x060009EE RID: 2542
		public extern void Close();

		// Token: 0x060009EF RID: 2543
		public static extern bool IsBestQualitySupported([In] CanvasDevice device);
	}
}
