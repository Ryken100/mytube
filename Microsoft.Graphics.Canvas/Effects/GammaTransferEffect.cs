using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000143 RID: 323
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class GammaTransferEffect : IGammaTransferEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000C40 RID: 3136
		public extern GammaTransferEffect();

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C41 RID: 3137
		// (set) Token: 0x06000C42 RID: 3138
		public extern float RedAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C43 RID: 3139
		// (set) Token: 0x06000C44 RID: 3140
		public extern float RedExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C45 RID: 3141
		// (set) Token: 0x06000C46 RID: 3142
		public extern float RedOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C47 RID: 3143
		// (set) Token: 0x06000C48 RID: 3144
		public extern bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C49 RID: 3145
		// (set) Token: 0x06000C4A RID: 3146
		public extern float GreenAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C4B RID: 3147
		// (set) Token: 0x06000C4C RID: 3148
		public extern float GreenExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C4D RID: 3149
		// (set) Token: 0x06000C4E RID: 3150
		public extern float GreenOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C4F RID: 3151
		// (set) Token: 0x06000C50 RID: 3152
		public extern bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C51 RID: 3153
		// (set) Token: 0x06000C52 RID: 3154
		public extern float BlueAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C53 RID: 3155
		// (set) Token: 0x06000C54 RID: 3156
		public extern float BlueExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C55 RID: 3157
		// (set) Token: 0x06000C56 RID: 3158
		public extern float BlueOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C57 RID: 3159
		// (set) Token: 0x06000C58 RID: 3160
		public extern bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000C59 RID: 3161
		// (set) Token: 0x06000C5A RID: 3162
		public extern float AlphaAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000C5B RID: 3163
		// (set) Token: 0x06000C5C RID: 3164
		public extern float AlphaExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000C5D RID: 3165
		// (set) Token: 0x06000C5E RID: 3166
		public extern float AlphaOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000C5F RID: 3167
		// (set) Token: 0x06000C60 RID: 3168
		public extern bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000C61 RID: 3169
		// (set) Token: 0x06000C62 RID: 3170
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C63 RID: 3171
		// (set) Token: 0x06000C64 RID: 3172
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C65 RID: 3173
		// (set) Token: 0x06000C66 RID: 3174
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C67 RID: 3175
		// (set) Token: 0x06000C68 RID: 3176
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C69 RID: 3177
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000C6A RID: 3178
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000C6B RID: 3179
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000C6C RID: 3180
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000C6D RID: 3181
		// (set) Token: 0x06000C6E RID: 3182
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C6F RID: 3183
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000C70 RID: 3184
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000C71 RID: 3185
		public extern void Close();
	}
}
