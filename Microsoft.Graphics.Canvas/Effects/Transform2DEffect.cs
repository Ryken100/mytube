using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000182 RID: 386
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class Transform2DEffect : ITransform2DEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06001022 RID: 4130
		public extern Transform2DEffect();

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001023 RID: 4131
		// (set) Token: 0x06001024 RID: 4132
		public extern CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001025 RID: 4133
		// (set) Token: 0x06001026 RID: 4134
		public extern EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001027 RID: 4135
		// (set) Token: 0x06001028 RID: 4136
		public extern Matrix3x2 TransformMatrix
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001029 RID: 4137
		// (set) Token: 0x0600102A RID: 4138
		public extern float Sharpness
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600102B RID: 4139
		// (set) Token: 0x0600102C RID: 4140
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600102D RID: 4141
		// (set) Token: 0x0600102E RID: 4142
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600102F RID: 4143
		// (set) Token: 0x06001030 RID: 4144
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001031 RID: 4145
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06001032 RID: 4146
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06001033 RID: 4147
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06001034 RID: 4148
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001035 RID: 4149
		// (set) Token: 0x06001036 RID: 4150
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001037 RID: 4151
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06001038 RID: 4152
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06001039 RID: 4153
		public extern void Close();
	}
}
