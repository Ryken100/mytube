using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasTextLayoutRegion
	{
		public int CharacterIndex;

		public int CharacterCount;

		public Rect LayoutBounds;
	}
}
