using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasTypographyFeature
	{
		public CanvasTypographyFeatureName Name;

		public uint Parameter;
	}
}
