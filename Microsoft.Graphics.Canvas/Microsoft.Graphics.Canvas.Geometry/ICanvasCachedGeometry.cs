using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasCachedGeometry))]
	[Windows.Foundation.Metadata.Guid(3127685396u, 57761, 17549, 171, 124, 141, 43, 146, 103, 65, 25)]
	[Version(167772160u)]
	internal interface ICanvasCachedGeometry : IDisposable
	{
		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
