using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1549181775u, 25119, 22002, 141, 113, 62, 58, 110, 105, 6, 189)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TextCommandBarFlyout))]
	internal interface ITextCommandBarFlyoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TextCommandBarFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
