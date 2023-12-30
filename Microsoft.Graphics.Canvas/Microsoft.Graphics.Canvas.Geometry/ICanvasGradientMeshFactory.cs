using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1196837165u, 9502, 16925, 131, 77, 135, 236, 38, 13, 94, 77)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	internal interface ICanvasGradientMeshFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGradientMesh Create([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientMeshPatch[] patchElements);
	}
}
