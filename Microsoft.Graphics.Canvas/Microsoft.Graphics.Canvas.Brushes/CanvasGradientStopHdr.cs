using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasGradientStopHdr
	{
		public float Position;

		public Vector4 Color;
	}
}
