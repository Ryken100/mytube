using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasGlyph
	{
		public int Index;

		public float Advance;

		public float AdvanceOffset;

		public float AscenderOffset;
	}
}
