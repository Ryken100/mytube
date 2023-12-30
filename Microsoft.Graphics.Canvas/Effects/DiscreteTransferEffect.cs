using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000132 RID: 306
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class DiscreteTransferEffect : IDiscreteTransferEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000AFC RID: 2812
		public extern DiscreteTransferEffect();

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000AFD RID: 2813
		// (set) Token: 0x06000AFE RID: 2814
		public extern float[] RedTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000AFF RID: 2815
		// (set) Token: 0x06000B00 RID: 2816
		public extern bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000B01 RID: 2817
		// (set) Token: 0x06000B02 RID: 2818
		public extern float[] GreenTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000B03 RID: 2819
		// (set) Token: 0x06000B04 RID: 2820
		public extern bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B05 RID: 2821
		// (set) Token: 0x06000B06 RID: 2822
		public extern float[] BlueTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B07 RID: 2823
		// (set) Token: 0x06000B08 RID: 2824
		public extern bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000B09 RID: 2825
		// (set) Token: 0x06000B0A RID: 2826
		public extern float[] AlphaTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000B0B RID: 2827
		// (set) Token: 0x06000B0C RID: 2828
		public extern bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B0D RID: 2829
		// (set) Token: 0x06000B0E RID: 2830
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000B0F RID: 2831
		// (set) Token: 0x06000B10 RID: 2832
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000B11 RID: 2833
		// (set) Token: 0x06000B12 RID: 2834
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000B13 RID: 2835
		// (set) Token: 0x06000B14 RID: 2836
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B15 RID: 2837
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000B16 RID: 2838
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000B17 RID: 2839
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000B18 RID: 2840
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000B19 RID: 2841
		// (set) Token: 0x06000B1A RID: 2842
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B1B RID: 2843
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000B1C RID: 2844
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000B1D RID: 2845
		public extern void Close();
	}
}
