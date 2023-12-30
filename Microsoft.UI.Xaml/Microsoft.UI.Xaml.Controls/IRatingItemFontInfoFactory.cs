using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(RatingItemFontInfo))]
	[Windows.Foundation.Metadata.Guid(278684993u, 28782, 24535, 186, 174, 2, 11, 36, 137, 159, 97)]
	[WebHostHidden]
	internal interface IRatingItemFontInfoFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RatingItemFontInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
