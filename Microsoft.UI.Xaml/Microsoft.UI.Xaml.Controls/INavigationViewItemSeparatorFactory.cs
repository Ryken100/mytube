using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(NavigationViewItemSeparator))]
	[Windows.Foundation.Metadata.Guid(403859105u, 54520, 23287, 129, 11, 174, 232, 161, 212, 82, 237)]
	internal interface INavigationViewItemSeparatorFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItemSeparator CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
