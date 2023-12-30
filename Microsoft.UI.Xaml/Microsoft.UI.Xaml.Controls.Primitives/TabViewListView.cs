using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Composable(typeof(ITabViewListViewFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public class TabViewListView : ListView, ITabViewListView
	{
	}
}
