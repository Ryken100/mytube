using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasTextRenderingMode
	{
		Default,
		Aliased,
		GdiClassic,
		GdiNatural,
		Natural,
		NaturalSymmetric,
		Outline,
		NaturalSymmetricDownsampled
	}
}
