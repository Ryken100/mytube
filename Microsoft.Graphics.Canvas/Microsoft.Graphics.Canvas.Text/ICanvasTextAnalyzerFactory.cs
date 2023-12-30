using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasTextAnalyzer))]
	[Windows.Foundation.Metadata.Guid(1377715007u, 63128, 17600, 141, 127, 254, 55, 79, 229, 57, 225)]
	[Version(167772160u)]
	internal interface ICanvasTextAnalyzerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextAnalyzer Create([In] string text, [In] CanvasTextDirection textDirection);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextAnalyzer CreateWithNumberSubstitutionAndVerticalGlyphOrientationAndBidiLevel([In] string text, [In] CanvasTextDirection textDirection, [In] CanvasNumberSubstitution numberSubstitution, [In] CanvasVerticalGlyphOrientation verticalGlyphOrientation, [In] uint bidiLevel);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextAnalyzer CreateWithOptions([In] string text, [In] CanvasTextDirection textDirection, [In] ICanvasTextAnalyzerOptions options);
	}
}
