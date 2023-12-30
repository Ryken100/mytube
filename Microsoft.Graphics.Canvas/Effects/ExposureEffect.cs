using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000141 RID: 321
	[Threading(3)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class ExposureEffect : IExposureEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000C0A RID: 3082
		public extern ExposureEffect();

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C0B RID: 3083
		// (set) Token: 0x06000C0C RID: 3084
		public extern float Exposure
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C0D RID: 3085
		// (set) Token: 0x06000C0E RID: 3086
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C0F RID: 3087
		// (set) Token: 0x06000C10 RID: 3088
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C11 RID: 3089
		// (set) Token: 0x06000C12 RID: 3090
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C13 RID: 3091
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000C14 RID: 3092
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000C15 RID: 3093
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000C16 RID: 3094
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C17 RID: 3095
		// (set) Token: 0x06000C18 RID: 3096
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C19 RID: 3097
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000C1A RID: 3098
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000C1B RID: 3099
		public extern void Close();
	}
}
