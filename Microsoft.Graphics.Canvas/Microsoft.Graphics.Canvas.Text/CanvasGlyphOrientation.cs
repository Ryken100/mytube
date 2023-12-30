using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasGlyphOrientation
	{
		Upright,
		Clockwise90Degrees,
		Clockwise180Degrees,
		Clockwise270Degrees
	}
}
