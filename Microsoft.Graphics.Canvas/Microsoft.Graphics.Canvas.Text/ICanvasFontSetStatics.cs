using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Windows.Foundation.Metadata.Guid(1598191054u, 48378, 18629, 158, 103, 251, 233, 134, 109, 73, 36)]
	[Version(167772160u)]
	internal interface ICanvasFontSetStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasFontSet GetSystemFontSet();
	}
}
