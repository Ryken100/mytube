using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200018B RID: 395
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class VignetteEffect : IVignetteEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x0600109E RID: 4254
		public extern VignetteEffect();

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600109F RID: 4255
		// (set) Token: 0x060010A0 RID: 4256
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060010A1 RID: 4257
		// (set) Token: 0x060010A2 RID: 4258
		public extern float Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060010A3 RID: 4259
		// (set) Token: 0x060010A4 RID: 4260
		public extern float Curve
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060010A5 RID: 4261
		// (set) Token: 0x060010A6 RID: 4262
		public extern Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060010A7 RID: 4263
		// (set) Token: 0x060010A8 RID: 4264
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060010A9 RID: 4265
		// (set) Token: 0x060010AA RID: 4266
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060010AB RID: 4267
		// (set) Token: 0x060010AC RID: 4268
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x060010AD RID: 4269
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x060010AE RID: 4270
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x060010AF RID: 4271
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x060010B0 RID: 4272
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060010B1 RID: 4273
		// (set) Token: 0x060010B2 RID: 4274
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x060010B3 RID: 4275
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x060010B4 RID: 4276
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x060010B5 RID: 4277
		public extern void Close();
	}
}
