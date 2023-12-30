using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000180 RID: 384
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[Static(typeof(ITintEffectStatics), 167772160U)]
	public sealed class TintEffect : ITintEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06001001 RID: 4097
		public extern TintEffect();

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001002 RID: 4098
		// (set) Token: 0x06001003 RID: 4099
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001004 RID: 4100
		// (set) Token: 0x06001005 RID: 4101
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001006 RID: 4102
		// (set) Token: 0x06001007 RID: 4103
		public extern Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001008 RID: 4104
		// (set) Token: 0x06001009 RID: 4105
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600100A RID: 4106
		// (set) Token: 0x0600100B RID: 4107
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600100C RID: 4108
		// (set) Token: 0x0600100D RID: 4109
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600100E RID: 4110
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x0600100F RID: 4111
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06001010 RID: 4112
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06001011 RID: 4113
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001012 RID: 4114
		// (set) Token: 0x06001013 RID: 4115
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06001014 RID: 4116
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06001015 RID: 4117
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06001016 RID: 4118
		public extern void Close();

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001017 RID: 4119
		public static extern bool IsSupported { get; }
	}
}
