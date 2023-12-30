using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasGlyphMetrics
	{
		public float LeftSideBearing;

		public float AdvanceWidth;

		public float RightSideBearing;

		public float TopSideBearing;

		public float AdvanceHeight;

		public float BottomSideBearing;

		public float VerticalOrigin;

		public Rect DrawBounds;
	}
}
