using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000078 RID: 120
	[Guid(1811688433U, 2682, 17564, 167, 239, 103, 6, 50, 27, 12, 26)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	internal interface ICanvasGradientMesh : IClosable
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000415 RID: 1045
		CanvasGradientMeshPatch[] Patches { get; }

		// Token: 0x06000416 RID: 1046
		[Overload("GetBounds")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000417 RID: 1047
		[Overload("GetBoundsWithTransform")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000418 RID: 1048
		CanvasDevice Device { get; }
	}
}
