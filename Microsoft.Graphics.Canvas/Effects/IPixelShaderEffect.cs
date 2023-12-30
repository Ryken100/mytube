using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x020000FE RID: 254
	[Version(167772160U)]
	[Guid(4237048881U, 64150, 17890, 139, 114, 23, 65, 198, 92, 238, 142)]
	[ExclusiveTo(typeof(PixelShaderEffect))]
	internal interface IPixelShaderEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000841 RID: 2113
		IMap<string, object> Properties { get; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000842 RID: 2114
		// (set) Token: 0x0600084A RID: 2122
		IGraphicsEffectSource Source1
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000843 RID: 2115
		// (set) Token: 0x0600084B RID: 2123
		IGraphicsEffectSource Source2
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000844 RID: 2116
		// (set) Token: 0x0600084C RID: 2124
		IGraphicsEffectSource Source3
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000845 RID: 2117
		// (set) Token: 0x0600084D RID: 2125
		IGraphicsEffectSource Source4
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000846 RID: 2118
		// (set) Token: 0x0600084E RID: 2126
		IGraphicsEffectSource Source5
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000847 RID: 2119
		// (set) Token: 0x0600084F RID: 2127
		IGraphicsEffectSource Source6
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000848 RID: 2120
		// (set) Token: 0x06000850 RID: 2128
		IGraphicsEffectSource Source7
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000849 RID: 2121
		// (set) Token: 0x06000851 RID: 2129
		IGraphicsEffectSource Source8
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000852 RID: 2130
		// (set) Token: 0x0600085A RID: 2138
		SamplerCoordinateMapping Source1Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000853 RID: 2131
		// (set) Token: 0x0600085B RID: 2139
		SamplerCoordinateMapping Source2Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000854 RID: 2132
		// (set) Token: 0x0600085C RID: 2140
		SamplerCoordinateMapping Source3Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000855 RID: 2133
		// (set) Token: 0x0600085D RID: 2141
		SamplerCoordinateMapping Source4Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000856 RID: 2134
		// (set) Token: 0x0600085E RID: 2142
		SamplerCoordinateMapping Source5Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000857 RID: 2135
		// (set) Token: 0x0600085F RID: 2143
		SamplerCoordinateMapping Source6Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000858 RID: 2136
		// (set) Token: 0x06000860 RID: 2144
		SamplerCoordinateMapping Source7Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000859 RID: 2137
		// (set) Token: 0x06000861 RID: 2145
		SamplerCoordinateMapping Source8Mapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000862 RID: 2146
		// (set) Token: 0x0600086A RID: 2154
		EffectBorderMode Source1BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000863 RID: 2147
		// (set) Token: 0x0600086B RID: 2155
		EffectBorderMode Source2BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000864 RID: 2148
		// (set) Token: 0x0600086C RID: 2156
		EffectBorderMode Source3BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000865 RID: 2149
		// (set) Token: 0x0600086D RID: 2157
		EffectBorderMode Source4BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000866 RID: 2150
		// (set) Token: 0x0600086E RID: 2158
		EffectBorderMode Source5BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000867 RID: 2151
		// (set) Token: 0x0600086F RID: 2159
		EffectBorderMode Source6BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000868 RID: 2152
		// (set) Token: 0x06000870 RID: 2160
		EffectBorderMode Source7BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000869 RID: 2153
		// (set) Token: 0x06000871 RID: 2161
		EffectBorderMode Source8BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000872 RID: 2162
		// (set) Token: 0x06000873 RID: 2163
		int MaxSamplerOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000874 RID: 2164
		// (set) Token: 0x0600087C RID: 2172
		CanvasImageInterpolation Source1Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000875 RID: 2165
		// (set) Token: 0x0600087D RID: 2173
		CanvasImageInterpolation Source2Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000876 RID: 2166
		// (set) Token: 0x0600087E RID: 2174
		CanvasImageInterpolation Source3Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000877 RID: 2167
		// (set) Token: 0x0600087F RID: 2175
		CanvasImageInterpolation Source4Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000880 RID: 2176
		CanvasImageInterpolation Source5Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000879 RID: 2169
		// (set) Token: 0x06000881 RID: 2177
		CanvasImageInterpolation Source6Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600087A RID: 2170
		// (set) Token: 0x06000882 RID: 2178
		CanvasImageInterpolation Source7Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600087B RID: 2171
		// (set) Token: 0x06000883 RID: 2179
		CanvasImageInterpolation Source8Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000884 RID: 2180
		bool IsSupported([In] CanvasDevice device);
	}
}
