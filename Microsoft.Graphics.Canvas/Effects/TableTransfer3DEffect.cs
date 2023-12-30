using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000179 RID: 377
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Activatable(167772160U)]
	public sealed class TableTransfer3DEffect : ITableTransfer3DEffect, ICanvasEffect, ICanvasImage, IClosable, IGraphicsEffectSource, IGraphicsEffect
	{
		// Token: 0x06000FB4 RID: 4020
		public extern TableTransfer3DEffect();

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000FB5 RID: 4021
		// (set) Token: 0x06000FB6 RID: 4022
		public extern EffectTransferTable3D Table
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000FB7 RID: 4023
		// (set) Token: 0x06000FB8 RID: 4024
		public extern CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000FB9 RID: 4025
		// (set) Token: 0x06000FBA RID: 4026
		public extern IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000FBB RID: 4027
		// (set) Token: 0x06000FBC RID: 4028
		public extern bool CacheOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000FBD RID: 4029
		// (set) Token: 0x06000FBE RID: 4030
		public extern IReference<CanvasBufferPrecision> BufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FBF RID: 4031
		public extern void InvalidateSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] uint sourceIndex, [In] Rect invalidRectangle);

		// Token: 0x06000FC0 RID: 4032
		public extern Rect[] GetInvalidRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator);

		// Token: 0x06000FC1 RID: 4033
		public extern Rect GetRequiredSourceRectangle([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect sourceEffect, [In] uint sourceIndex, [In] Rect sourceBounds);

		// Token: 0x06000FC2 RID: 4034
		public extern Rect[] GetRequiredSourceRectangles([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Rect outputRectangle, [In] ICanvasEffect[] sourceEffects, [In] uint[] sourceIndices, [In] Rect[] sourceBounds);

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000FC3 RID: 4035
		// (set) Token: 0x06000FC4 RID: 4036
		public extern string Name
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000FC5 RID: 4037
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000FC6 RID: 4038
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000FC7 RID: 4039
		public extern void Close();
	}
}
