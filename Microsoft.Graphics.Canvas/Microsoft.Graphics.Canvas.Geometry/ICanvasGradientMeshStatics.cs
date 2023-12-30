using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	[Windows.Foundation.Metadata.Guid(1141012032u, 16043, 16793, 170, 59, 100, 72, 144, 208, 18, 61)]
	[Version(167772160u)]
	internal interface ICanvasGradientMeshStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGradientMeshPatch CreateCoonsPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGradientMeshPatch CreateTensorPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);
	}
}
