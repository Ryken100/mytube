using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1697089192u, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 110)]
	[Version(167772160u)]
	public interface ICanvasSvgAttribute : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ICanvasSvgAttribute Clone();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgNamedElement GetElement();

		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
