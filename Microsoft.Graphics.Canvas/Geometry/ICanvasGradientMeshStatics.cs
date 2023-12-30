using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200007B RID: 123
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	[Guid(1141012032U, 16043, 16793, 170, 59, 100, 72, 144, 208, 18, 61)]
	[Version(167772160U)]
	internal interface ICanvasGradientMeshStatics
	{
		// Token: 0x06000422 RID: 1058
		CanvasGradientMeshPatch CreateCoonsPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);

		// Token: 0x06000423 RID: 1059
		CanvasGradientMeshPatch CreateTensorPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);
	}
}
