using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(837959786u, 35935, 19986, 139, 214, 207, 187, 199, 33, 77, 2)]
	public interface ICanvasTextAnalyzerOptions
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetLocaleName([In] int characterIndex, out int characterCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasNumberSubstitution GetNumberSubstitution([In] int characterIndex, out int characterCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasVerticalGlyphOrientation GetVerticalGlyphOrientation([In] int characterIndex, out int characterCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetBidiLevel([In] int characterIndex, out int characterCount);
	}
}
