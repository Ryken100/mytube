using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasSvgPathCommand
	{
		ClosePath,
		MoveAbsolute,
		MoveRelative,
		LineAbsolute,
		LineRelative,
		CubicAbsolute,
		CubicRelative,
		QuadraticAbsolute,
		QuadraticRelative,
		ArcAbsolute,
		ArcRelative,
		HorizontalAbsolute,
		HorizontalRelative,
		VerticalAbsolute,
		VerticalRelative,
		CubicSmoothAbsolute,
		CubicSmoothRelative,
		QuadraticSmoothAbsolute,
		QuadraticSmoothRelative
	}
}
