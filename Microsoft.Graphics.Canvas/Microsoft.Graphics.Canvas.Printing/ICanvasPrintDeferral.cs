using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasPrintDeferral))]
	[Windows.Foundation.Metadata.Guid(147495330u, 22529, 20132, 134, 135, 137, 108, 189, 166, 154, 71)]
	[Version(167772160u)]
	internal interface ICanvasPrintDeferral
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Complete();
	}
}
