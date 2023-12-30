using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[Composable(typeof(INavigationViewItemSeparatorFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class NavigationViewItemSeparator : NavigationViewItemBase, INavigationViewItemSeparator
	{
	}
}
