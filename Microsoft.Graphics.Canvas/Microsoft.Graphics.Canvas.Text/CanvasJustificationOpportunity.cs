using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasJustificationOpportunity
	{
		public float ExpansionMinimum;

		public float ExpansionMaximum;

		public float CompressionMaximum;

		public byte ExpansionPriority;

		public byte CompressionPriority;

		public bool AllowResidualExpansion;

		public bool AllowResidualCompression;

		public bool ApplyToLeadingEdge;

		public bool ApplyToTrailingEdge;
	}
}
