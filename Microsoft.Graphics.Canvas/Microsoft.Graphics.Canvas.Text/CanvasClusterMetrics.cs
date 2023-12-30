using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasClusterMetrics
	{
		public int CharacterCount;

		public float Width;

		public CanvasClusterProperties Properties;
	}
}
