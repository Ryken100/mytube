using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasFontFileFormatType
	{
		Cff,
		TrueType,
		TrueTypeCollection,
		Type1,
		Vector,
		Bitmap,
		Unknown,
		RawCff
	}
}
