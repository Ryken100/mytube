using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000110 RID: 272
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class ArithmeticCompositeEffect : IArithmeticCompositeEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x0600091A RID: 2330
		public extern ArithmeticCompositeEffect();

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600091B RID: 2331
		// (set) Token: 0x0600091C RID: 2332
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600091D RID: 2333
		// (set) Token: 0x0600091E RID: 2334
		public extern float MultiplyAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600091F RID: 2335
		// (set) Token: 0x06000920 RID: 2336
		public extern float Source1Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000921 RID: 2337
		// (set) Token: 0x06000922 RID: 2338
		public extern float Source2Amount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000923 RID: 2339
		// (set) Token: 0x06000924 RID: 2340
		public extern float Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000925 RID: 2341
		// (set) Token: 0x06000926 RID: 2342
		public extern IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000927 RID: 2343
		// (set) Token: 0x06000928 RID: 2344
		public extern IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000929 RID: 2345
		// (set) Token: 0x0600092A RID: 2346
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600092B RID: 2347
		// (set) Token: 0x0600092C RID: 2348
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600092D RID: 2349
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x0600092E RID: 2350
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x0600092F RID: 2351
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000930 RID: 2352
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000931 RID: 2353
		// (set) Token: 0x06000932 RID: 2354
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000933 RID: 2355
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000934 RID: 2356
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000935 RID: 2357
		public extern void Close();
	}
}
