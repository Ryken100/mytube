using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(125160321u, 50517, 17855, 151, 149, 15, 245, 145, 81, 195, 190)]
	[Version(167772160u)]
	public interface ICanvasSvgElement : IDisposable
	{
		CanvasSvgDocument ContainingDocument
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasSvgNamedElement Parent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
