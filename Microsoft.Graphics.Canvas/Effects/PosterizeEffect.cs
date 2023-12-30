using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000161 RID: 353
	[Threading(3)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class PosterizeEffect : IPosterizeEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000E12 RID: 3602
		public extern PosterizeEffect();

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E13 RID: 3603
		// (set) Token: 0x06000E14 RID: 3604
		public extern int RedValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000E15 RID: 3605
		// (set) Token: 0x06000E16 RID: 3606
		public extern int GreenValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E17 RID: 3607
		// (set) Token: 0x06000E18 RID: 3608
		public extern int BlueValueCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E19 RID: 3609
		// (set) Token: 0x06000E1A RID: 3610
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E1B RID: 3611
		// (set) Token: 0x06000E1C RID: 3612
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E1D RID: 3613
		// (set) Token: 0x06000E1E RID: 3614
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E1F RID: 3615
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000E20 RID: 3616
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000E21 RID: 3617
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000E22 RID: 3618
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E23 RID: 3619
		// (set) Token: 0x06000E24 RID: 3620
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000E25 RID: 3621
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000E26 RID: 3622
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000E27 RID: 3623
		public extern void Close();
	}
}
