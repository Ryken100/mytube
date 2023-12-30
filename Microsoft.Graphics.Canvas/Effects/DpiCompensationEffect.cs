using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200013A RID: 314
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	public sealed class DpiCompensationEffect : IDpiCompensationEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000BB0 RID: 2992
		public extern DpiCompensationEffect();

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BB1 RID: 2993
		// (set) Token: 0x06000BB2 RID: 2994
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000BB5 RID: 2997
		// (set) Token: 0x06000BB6 RID: 2998
		public extern Vector2 SourceDpi
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BB7 RID: 2999
		// (set) Token: 0x06000BB8 RID: 3000
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000BB9 RID: 3001
		// (set) Token: 0x06000BBA RID: 3002
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000BBB RID: 3003
		// (set) Token: 0x06000BBC RID: 3004
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BBD RID: 3005
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000BBE RID: 3006
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000BBF RID: 3007
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000BC0 RID: 3008
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000BC1 RID: 3009
		// (set) Token: 0x06000BC2 RID: 3010
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000BC3 RID: 3011
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000BC4 RID: 3012
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000BC5 RID: 3013
		public extern void Close();
	}
}
