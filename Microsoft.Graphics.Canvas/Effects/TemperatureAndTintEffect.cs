using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017B RID: 379
	[Threading(3)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class TemperatureAndTintEffect : ITemperatureAndTintEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000FCE RID: 4046
		public extern TemperatureAndTintEffect();

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FCF RID: 4047
		// (set) Token: 0x06000FD0 RID: 4048
		public extern float Temperature
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000FD1 RID: 4049
		// (set) Token: 0x06000FD2 RID: 4050
		public extern float Tint
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000FD3 RID: 4051
		// (set) Token: 0x06000FD4 RID: 4052
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000FD5 RID: 4053
		// (set) Token: 0x06000FD6 RID: 4054
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000FD7 RID: 4055
		// (set) Token: 0x06000FD8 RID: 4056
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FD9 RID: 4057
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000FDA RID: 4058
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000FDB RID: 4059
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000FDC RID: 4060
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000FDD RID: 4061
		// (set) Token: 0x06000FDE RID: 4062
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FDF RID: 4063
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000FE0 RID: 4064
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000FE1 RID: 4065
		public extern void Close();
	}
}
