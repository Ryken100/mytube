using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008E RID: 142
	[Guid(2159677536U, 43479, 16826, 147, 114, 236, 63, 193, 116, 78, 93)]
	[ExclusiveTo(typeof(CanvasCachedGeometry))]
	[Version(167772160U)]
	internal interface ICanvasCachedGeometryStatics
	{
		// Token: 0x06000495 RID: 1173
		[Overload("CreateFill")]
		CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry);

		// Token: 0x06000496 RID: 1174
		[Overload("CreateFillWithFlatteningTolerance")]
		[DefaultOverload]
		CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry, [In] float flatteningTolerance);

		// Token: 0x06000497 RID: 1175
		[Overload("CreateStroke")]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth);

		// Token: 0x06000498 RID: 1176
		[Overload("CreateStrokeWithStrokeStyle")]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000499 RID: 1177
		[Overload("CreateStrokeWithStrokeStyleAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] float flatteningTolerance);
	}
}
