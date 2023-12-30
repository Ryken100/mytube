using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000125 RID: 293
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class CompositeEffect : ICompositeEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000A27 RID: 2599
		public extern CompositeEffect();

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000A28 RID: 2600
		// (set) Token: 0x06000A29 RID: 2601
		public extern CanvasComposite Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000A2A RID: 2602
		public extern IVector<IGraphicsEffectSource> Sources { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000A2B RID: 2603
		// (set) Token: 0x06000A2C RID: 2604
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000A2D RID: 2605
		// (set) Token: 0x06000A2E RID: 2606
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A2F RID: 2607
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000A30 RID: 2608
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000A31 RID: 2609
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000A32 RID: 2610
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000A33 RID: 2611
		// (set) Token: 0x06000A34 RID: 2612
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A35 RID: 2613
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000A36 RID: 2614
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000A37 RID: 2615
		public extern void Close();
	}
}
