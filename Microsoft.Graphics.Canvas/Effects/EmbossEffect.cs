using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200013F RID: 319
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class EmbossEffect : IEmbossEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000BF2 RID: 3058
		public extern EmbossEffect();

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		public extern float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		public extern float Angle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000BF7 RID: 3063
		// (set) Token: 0x06000BF8 RID: 3064
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000BF9 RID: 3065
		// (set) Token: 0x06000BFA RID: 3066
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000BFB RID: 3067
		// (set) Token: 0x06000BFC RID: 3068
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BFD RID: 3069
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000BFE RID: 3070
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000BFF RID: 3071
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000C00 RID: 3072
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000C01 RID: 3073
		// (set) Token: 0x06000C02 RID: 3074
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C03 RID: 3075
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000C04 RID: 3076
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000C05 RID: 3077
		public extern void Close();
	}
}
