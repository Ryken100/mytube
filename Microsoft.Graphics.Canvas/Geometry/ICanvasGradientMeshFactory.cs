using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000079 RID: 121
	[Guid(1196837165U, 9502, 16925, 131, 77, 135, 236, 38, 13, 94, 77)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	internal interface ICanvasGradientMeshFactory
	{
		// Token: 0x06000419 RID: 1049
		CanvasGradientMesh Create([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientMeshPatch[] patchElements);
	}
}
