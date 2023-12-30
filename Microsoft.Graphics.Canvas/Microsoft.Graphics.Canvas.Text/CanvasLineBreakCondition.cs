using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasLineBreakCondition
	{
		Neutral,
		CanBreak,
		CannotBreak,
		MustBreak
	}
}
