using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	public enum BlendEffectMode
	{
		Multiply,
		Screen,
		Darken,
		Lighten,
		Dissolve,
		ColorBurn,
		LinearBurn,
		DarkerColor,
		LighterColor,
		ColorDodge,
		LinearDodge,
		Overlay,
		SoftLight,
		HardLight,
		VividLight,
		LinearLight,
		PinLight,
		HardMix,
		Difference,
		Exclusion,
		Hue,
		Saturation,
		Color,
		Luminosity,
		Subtract,
		Division
	}
}
