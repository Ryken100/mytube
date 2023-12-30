using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000177 RID: 375
	[Activatable(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class TableTransferEffect : ITableTransferEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000F8C RID: 3980
		public extern TableTransferEffect();

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000F8D RID: 3981
		// (set) Token: 0x06000F8E RID: 3982
		public extern float[] RedTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000F8F RID: 3983
		// (set) Token: 0x06000F90 RID: 3984
		public extern bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000F91 RID: 3985
		// (set) Token: 0x06000F92 RID: 3986
		public extern float[] GreenTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000F93 RID: 3987
		// (set) Token: 0x06000F94 RID: 3988
		public extern bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000F95 RID: 3989
		// (set) Token: 0x06000F96 RID: 3990
		public extern float[] BlueTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000F97 RID: 3991
		// (set) Token: 0x06000F98 RID: 3992
		public extern bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000F99 RID: 3993
		// (set) Token: 0x06000F9A RID: 3994
		public extern float[] AlphaTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000F9B RID: 3995
		// (set) Token: 0x06000F9C RID: 3996
		public extern bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000F9D RID: 3997
		// (set) Token: 0x06000F9E RID: 3998
		public extern bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000F9F RID: 3999
		// (set) Token: 0x06000FA0 RID: 4000
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000FA1 RID: 4001
		// (set) Token: 0x06000FA2 RID: 4002
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000FA3 RID: 4003
		// (set) Token: 0x06000FA4 RID: 4004
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FA5 RID: 4005
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000FA6 RID: 4006
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000FA7 RID: 4007
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000FA8 RID: 4008
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000FA9 RID: 4009
		// (set) Token: 0x06000FAA RID: 4010
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FAB RID: 4011
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000FAC RID: 4012
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000FAD RID: 4013
		public extern void Close();
	}
}
