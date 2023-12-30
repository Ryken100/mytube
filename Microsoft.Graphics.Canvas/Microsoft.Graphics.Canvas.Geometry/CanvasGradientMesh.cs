using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Activatable(typeof(ICanvasGradientMeshFactory), 167772160u)]
	[Static(typeof(ICanvasGradientMeshStatics), 167772160u)]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasGradientMesh : ICanvasGradientMesh, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasGradientMeshPatch[] Patches
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGradientMeshPatch CreateCoonsPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGradientMeshPatch CreateTensorPatch([In] Vector2[] points, [In] Vector4[] colors, [In] CanvasGradientMeshPatchEdge[] edges);
	}
}
