using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000189 RID: 393
	[Threading(3)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class UnPremultiplyEffect : IUnPremultiplyEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06001084 RID: 4228
		public extern UnPremultiplyEffect();

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001085 RID: 4229
		// (set) Token: 0x06001086 RID: 4230
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001087 RID: 4231
		// (set) Token: 0x06001088 RID: 4232
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001089 RID: 4233
		// (set) Token: 0x0600108A RID: 4234
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600108B RID: 4235
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x0600108C RID: 4236
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x0600108D RID: 4237
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x0600108E RID: 4238
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600108F RID: 4239
		// (set) Token: 0x06001090 RID: 4240
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001091 RID: 4241
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06001092 RID: 4242
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06001093 RID: 4243
		public extern void Close();
	}
}
