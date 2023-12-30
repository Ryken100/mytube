using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1811688433u, 2682, 17564, 167, 239, 103, 6, 50, 27, 12, 26)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasGradientMesh))]
	internal interface ICanvasGradientMesh : IDisposable
	{
		CanvasGradientMeshPatch[] Patches
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBounds")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBoundsWithTransform")]
		Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
