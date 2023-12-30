using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasGlyphJustification
	{
		None = 0,
		ArabicBlank = 1,
		Character = 2,
		Blank = 4,
		ArabicNormal = 7,
		ArabicKashida = 8,
		ArabicAlef = 9,
		ArabicHa = 10,
		ArabicRa = 11,
		ArabicBa = 12,
		ArabicBara = 13,
		ArabicSeen = 14,
		ArabicSeenM = 15
	}
}
