using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000187 RID: 391
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class TurbulenceEffect : ITurbulenceEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06001066 RID: 4198
		public extern TurbulenceEffect();

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001067 RID: 4199
		// (set) Token: 0x06001068 RID: 4200
		public extern Vector2 Offset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001069 RID: 4201
		// (set) Token: 0x0600106A RID: 4202
		public extern Vector2 Size
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600106B RID: 4203
		// (set) Token: 0x0600106C RID: 4204
		public extern Vector2 Frequency
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600106D RID: 4205
		// (set) Token: 0x0600106E RID: 4206
		public extern int Octaves
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600106F RID: 4207
		// (set) Token: 0x06001070 RID: 4208
		public extern int Seed
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001071 RID: 4209
		// (set) Token: 0x06001072 RID: 4210
		public extern TurbulenceEffectNoise Noise
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001073 RID: 4211
		// (set) Token: 0x06001074 RID: 4212
		public extern bool Tileable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001075 RID: 4213
		// (set) Token: 0x06001076 RID: 4214
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001077 RID: 4215
		// (set) Token: 0x06001078 RID: 4216
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001079 RID: 4217
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x0600107A RID: 4218
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x0600107B RID: 4219
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x0600107C RID: 4220
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600107D RID: 4221
		// (set) Token: 0x0600107E RID: 4222
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600107F RID: 4223
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06001080 RID: 4224
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06001081 RID: 4225
		public extern void Close();
	}
}
