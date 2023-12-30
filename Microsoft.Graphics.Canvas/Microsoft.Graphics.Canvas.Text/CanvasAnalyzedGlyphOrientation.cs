using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasAnalyzedGlyphOrientation
	{
		public CanvasGlyphOrientation GlyphOrientation;

		public uint AdjustedBidiLevel;

		public bool IsSideways;

		public bool IsRightToLeft;
	}
}
