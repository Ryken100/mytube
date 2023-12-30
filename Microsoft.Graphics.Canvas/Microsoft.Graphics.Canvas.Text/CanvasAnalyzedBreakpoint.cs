using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasAnalyzedBreakpoint
	{
		public CanvasLineBreakCondition BreakBefore;

		public CanvasLineBreakCondition BreakAfter;

		public bool IsWhitespace;

		public bool IsSoftHyphen;
	}
}
