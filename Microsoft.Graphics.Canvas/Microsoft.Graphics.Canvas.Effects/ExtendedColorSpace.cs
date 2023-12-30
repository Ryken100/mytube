using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	public enum ExtendedColorSpace
	{
		FullG22P709 = 0,
		FullG10P709 = 1,
		StudioG22P709 = 2,
		StudioG22P2020 = 3,
		FullG2084P2020 = 12,
		StudioG2084P2020 = 14,
		FullG22P2020 = 17,
		Custom = -1
	}
}
