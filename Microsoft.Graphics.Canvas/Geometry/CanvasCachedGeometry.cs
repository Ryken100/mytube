using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008F RID: 143
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Static(typeof(ICanvasCachedGeometryStatics), 167772160U)]
	[Version(167772160U)]
	public sealed class CanvasCachedGeometry : ICanvasCachedGeometry, IClosable
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600049A RID: 1178
		public extern CanvasDevice Device { get; }

		// Token: 0x0600049B RID: 1179
		public extern void Close();

		// Token: 0x0600049C RID: 1180
		[Overload("CreateFill")]
		public static extern CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry);

		// Token: 0x0600049D RID: 1181
		[Overload("CreateFillWithFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry, [In] float flatteningTolerance);

		// Token: 0x0600049E RID: 1182
		[Overload("CreateStroke")]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth);

		// Token: 0x0600049F RID: 1183
		[Overload("CreateStrokeWithStrokeStyle")]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060004A0 RID: 1184
		[Overload("CreateStrokeWithStrokeStyleAndFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] float flatteningTolerance);
	}
}
