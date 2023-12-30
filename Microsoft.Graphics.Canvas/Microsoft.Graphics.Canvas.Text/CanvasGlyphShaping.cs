using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasGlyphShaping
	{
		public CanvasGlyphJustification Justification;

		public bool IsClusterStart;

		public bool IsDiacritic;

		public bool IsZeroWidthSpace;
	}
}
