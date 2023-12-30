using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000184 RID: 388
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class Transform3DEffect : ITransform3DEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06001042 RID: 4162
		public extern Transform3DEffect();

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001043 RID: 4163
		// (set) Token: 0x06001044 RID: 4164
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001045 RID: 4165
		// (set) Token: 0x06001046 RID: 4166
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001047 RID: 4167
		// (set) Token: 0x06001048 RID: 4168
		public extern Matrix4x4 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001049 RID: 4169
		// (set) Token: 0x0600104A RID: 4170
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600104B RID: 4171
		// (set) Token: 0x0600104C RID: 4172
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600104D RID: 4173
		// (set) Token: 0x0600104E RID: 4174
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600104F RID: 4175
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06001050 RID: 4176
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06001051 RID: 4177
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06001052 RID: 4178
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001053 RID: 4179
		// (set) Token: 0x06001054 RID: 4180
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001055 RID: 4181
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06001056 RID: 4182
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06001057 RID: 4183
		public extern void Close();
	}
}
