using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010E RID: 270
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Static(typeof(IAlphaMaskEffectStatics), 167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class AlphaMaskEffect : IAlphaMaskEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x060008F9 RID: 2297
		public extern AlphaMaskEffect();

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060008FA RID: 2298
		// (set) Token: 0x060008FB RID: 2299
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060008FC RID: 2300
		// (set) Token: 0x060008FD RID: 2301
		public extern IGraphicsEffectSource AlphaMask
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060008FE RID: 2302
		// (set) Token: 0x060008FF RID: 2303
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000900 RID: 2304
		// (set) Token: 0x06000901 RID: 2305
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000902 RID: 2306
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000903 RID: 2307
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000904 RID: 2308
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000905 RID: 2309
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000906 RID: 2310
		// (set) Token: 0x06000907 RID: 2311
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000908 RID: 2312
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000909 RID: 2313
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x0600090A RID: 2314
		public extern void Close();

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600090B RID: 2315
		public static extern bool IsSupported { get; }
	}
}
