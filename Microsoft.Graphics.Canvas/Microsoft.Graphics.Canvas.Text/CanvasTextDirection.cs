using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasTextDirection
	{
		LeftToRightThenTopToBottom,
		RightToLeftThenTopToBottom,
		LeftToRightThenBottomToTop,
		RightToLeftThenBottomToTop,
		TopToBottomThenLeftToRight,
		BottomToTopThenLeftToRight,
		TopToBottomThenRightToLeft,
		BottomToTopThenRightToLeft
	}
}
