using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200002B RID: 43
	[Guid(251228044U, 39774, 19440, 163, 153, 170, 216, 206, 83, 219, 85)]
	[Version(167772160U)]
	public interface ICanvasEffect : IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000032 RID: 50
		// (set) Token: 0x06000033 RID: 51
		bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000034 RID: 52
		// (set) Token: 0x06000035 RID: 53
		IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000036 RID: 54
		void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000037 RID: 55
		Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000038 RID: 56
		Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000039 RID: 57
		Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);
	}
}
