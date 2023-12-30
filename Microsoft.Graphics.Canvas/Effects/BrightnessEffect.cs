using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000119 RID: 281
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	public sealed class BrightnessEffect : IBrightnessEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x0600098A RID: 2442
		public extern BrightnessEffect();

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600098B RID: 2443
		// (set) Token: 0x0600098C RID: 2444
		public extern Vector2 WhitePoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600098D RID: 2445
		// (set) Token: 0x0600098E RID: 2446
		public extern Vector2 BlackPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600098F RID: 2447
		// (set) Token: 0x06000990 RID: 2448
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000991 RID: 2449
		// (set) Token: 0x06000992 RID: 2450
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000993 RID: 2451
		// (set) Token: 0x06000994 RID: 2452
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000995 RID: 2453
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000996 RID: 2454
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000997 RID: 2455
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000998 RID: 2456
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000999 RID: 2457
		// (set) Token: 0x0600099A RID: 2458
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600099B RID: 2459
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x0600099C RID: 2460
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x0600099D RID: 2461
		public extern void Close();
	}
}
