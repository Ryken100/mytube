using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasLineMetrics
	{
		public int CharacterCount;

		public int TrailingWhitespaceCount;

		public int TerminalNewlineCount;

		public float Height;

		public float Baseline;

		public bool IsTrimmed;

		public float LeadingWhitespaceBefore;

		public float LeadingWhitespaceAfter;
	}
}
