using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Windows.Foundation.Metadata.Guid(3730874369u, 37765, 21813, 128, 225, 43, 104, 244, 191, 222, 38)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
