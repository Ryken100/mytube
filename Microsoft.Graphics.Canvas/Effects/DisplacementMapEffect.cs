using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000134 RID: 308
	[Version(167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class DisplacementMapEffect : IDisplacementMapEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000B28 RID: 2856
		public extern DisplacementMapEffect();

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000B29 RID: 2857
		// (set) Token: 0x06000B2A RID: 2858
		public extern float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000B2B RID: 2859
		// (set) Token: 0x06000B2C RID: 2860
		public extern EffectChannelSelect XChannelSelect
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000B2D RID: 2861
		// (set) Token: 0x06000B2E RID: 2862
		public extern EffectChannelSelect YChannelSelect
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000B2F RID: 2863
		// (set) Token: 0x06000B30 RID: 2864
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000B31 RID: 2865
		// (set) Token: 0x06000B32 RID: 2866
		public extern IGraphicsEffectSource Displacement
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000B33 RID: 2867
		// (set) Token: 0x06000B34 RID: 2868
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000B35 RID: 2869
		// (set) Token: 0x06000B36 RID: 2870
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B37 RID: 2871
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000B38 RID: 2872
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000B39 RID: 2873
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000B3A RID: 2874
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000B3B RID: 2875
		// (set) Token: 0x06000B3C RID: 2876
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B3D RID: 2877
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000B3E RID: 2878
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000B3F RID: 2879
		public extern void Close();
	}
}
