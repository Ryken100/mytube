using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2324854037u, 13308, 19602, 166, 170, 148, 168, 242, 156, 20, 11)]
	[ExclusiveTo(typeof(CanvasTextFormat))]
	[Version(167772160u)]
	internal interface ICanvasTextFormatStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSystemFontFamilies")]
		string[] GetSystemFontFamilies();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSystemFontFamiliesFromLocaleList")]
		string[] GetSystemFontFamilies([In] IReadOnlyList<string> localeList);
	}
}
