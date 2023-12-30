using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasGeometryCombine
	{
		Union,
		Intersect,
		Xor,
		Exclude
	}
}
