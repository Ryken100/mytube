using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasSvgPaintType
	{
		None,
		Color,
		CurrentColor,
		Uri,
		UriThenNone,
		UriThenColor,
		UriThenCurrentColor
	}
}
