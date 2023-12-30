using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000100 RID: 256
	[Version(167772160U)]
	[Activatable(typeof(IPixelShaderEffectFactory), 167772160U)]
	public sealed class PixelShaderEffect : IPixelShaderEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000886 RID: 2182
		public extern PixelShaderEffect([In] byte[] shaderCode);

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000887 RID: 2183
		public extern IMap<string, object> Properties { get; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000888 RID: 2184
		// (set) Token: 0x06000890 RID: 2192
		public extern IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000889 RID: 2185
		// (set) Token: 0x06000891 RID: 2193
		public extern IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600088A RID: 2186
		// (set) Token: 0x06000892 RID: 2194
		public extern IGraphicsEffectSource Source3
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600088B RID: 2187
		// (set) Token: 0x06000893 RID: 2195
		public extern IGraphicsEffectSource Source4
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600088C RID: 2188
		// (set) Token: 0x06000894 RID: 2196
		public extern IGraphicsEffectSource Source5
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600088D RID: 2189
		// (set) Token: 0x06000895 RID: 2197
		public extern IGraphicsEffectSource Source6
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600088E RID: 2190
		// (set) Token: 0x06000896 RID: 2198
		public extern IGraphicsEffectSource Source7
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600088F RID: 2191
		// (set) Token: 0x06000897 RID: 2199
		public extern IGraphicsEffectSource Source8
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000898 RID: 2200
		// (set) Token: 0x060008A0 RID: 2208
		public extern SamplerCoordinateMapping Source1Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000899 RID: 2201
		// (set) Token: 0x060008A1 RID: 2209
		public extern SamplerCoordinateMapping Source2Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600089A RID: 2202
		// (set) Token: 0x060008A2 RID: 2210
		public extern SamplerCoordinateMapping Source3Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600089B RID: 2203
		// (set) Token: 0x060008A3 RID: 2211
		public extern SamplerCoordinateMapping Source4Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600089C RID: 2204
		// (set) Token: 0x060008A4 RID: 2212
		public extern SamplerCoordinateMapping Source5Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600089D RID: 2205
		// (set) Token: 0x060008A5 RID: 2213
		public extern SamplerCoordinateMapping Source6Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600089E RID: 2206
		// (set) Token: 0x060008A6 RID: 2214
		public extern SamplerCoordinateMapping Source7Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600089F RID: 2207
		// (set) Token: 0x060008A7 RID: 2215
		public extern SamplerCoordinateMapping Source8Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008A8 RID: 2216
		// (set) Token: 0x060008B0 RID: 2224
		public extern EffectBorderMode Source1BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008A9 RID: 2217
		// (set) Token: 0x060008B1 RID: 2225
		public extern EffectBorderMode Source2BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060008AA RID: 2218
		// (set) Token: 0x060008B2 RID: 2226
		public extern EffectBorderMode Source3BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060008AB RID: 2219
		// (set) Token: 0x060008B3 RID: 2227
		public extern EffectBorderMode Source4BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008AC RID: 2220
		// (set) Token: 0x060008B4 RID: 2228
		public extern EffectBorderMode Source5BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060008AD RID: 2221
		// (set) Token: 0x060008B5 RID: 2229
		public extern EffectBorderMode Source6BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008AE RID: 2222
		// (set) Token: 0x060008B6 RID: 2230
		public extern EffectBorderMode Source7BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008AF RID: 2223
		// (set) Token: 0x060008B7 RID: 2231
		public extern EffectBorderMode Source8BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008B8 RID: 2232
		// (set) Token: 0x060008B9 RID: 2233
		public extern int MaxSamplerOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008BA RID: 2234
		// (set) Token: 0x060008C2 RID: 2242
		public extern CanvasImageInterpolation Source1Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008BB RID: 2235
		// (set) Token: 0x060008C3 RID: 2243
		public extern CanvasImageInterpolation Source2Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060008BC RID: 2236
		// (set) Token: 0x060008C4 RID: 2244
		public extern CanvasImageInterpolation Source3Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060008BD RID: 2237
		// (set) Token: 0x060008C5 RID: 2245
		public extern CanvasImageInterpolation Source4Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060008BE RID: 2238
		// (set) Token: 0x060008C6 RID: 2246
		public extern CanvasImageInterpolation Source5Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060008BF RID: 2239
		// (set) Token: 0x060008C7 RID: 2247
		public extern CanvasImageInterpolation Source6Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008C0 RID: 2240
		// (set) Token: 0x060008C8 RID: 2248
		public extern CanvasImageInterpolation Source7Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008C1 RID: 2241
		// (set) Token: 0x060008C9 RID: 2249
		public extern CanvasImageInterpolation Source8Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x060008CA RID: 2250
		public extern bool IsSupported([In] CanvasDevice device);

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008CB RID: 2251
		// (set) Token: 0x060008CC RID: 2252
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060008CD RID: 2253
		// (set) Token: 0x060008CE RID: 2254
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x060008CF RID: 2255
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x060008D0 RID: 2256
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x060008D1 RID: 2257
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x060008D2 RID: 2258
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060008D3 RID: 2259
		// (set) Token: 0x060008D4 RID: 2260
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x060008D5 RID: 2261
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x060008D6 RID: 2262
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x060008D7 RID: 2263
		public extern void Close();
	}
}
