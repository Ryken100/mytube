using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200007A RID: 122
	[Activatable(typeof(ICanvasGradientMeshFactory), 167772160U)]
	[Static(typeof(ICanvasGradientMeshStatics), 167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasGradientMesh : ICanvasGradientMesh, IClosable
	{
		// Token: 0x0600041A RID: 1050
		public extern CanvasGradientMesh([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientMeshPatch[] patchElements);

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x0600041B RID: 1051
		public extern CanvasGradientMeshPatch[] Patches { get; }

		// Token: 0x0600041C RID: 1052
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x0600041D RID: 1053
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600041E RID: 1054
		public extern CanvasDevice Device { get; }

		// Token: 0x0600041F RID: 1055
		public extern void Close();

		// Token: 0x06000420 RID: 1056
		public static extern CanvasGradientMeshPatch CreateCoonsPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);

		// Token: 0x06000421 RID: 1057
		public static extern CanvasGradientMeshPatch CreateTensorPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);
	}
}
