using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasSvgAspectAlignment
	{
		None,
		XMinYMin,
		XMidYMin,
		XMaxYMin,
		XMinYMid,
		XMidYMid,
		XMaxYMid,
		XMinYMax,
		XMidYMax,
		XMaxYMax
	}
}
