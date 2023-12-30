using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	public enum ColorManagementRenderingIntent
	{
		Perceptual,
		RelativeColorimetric,
		Saturation,
		AbsoluteColorimetric
	}
}
