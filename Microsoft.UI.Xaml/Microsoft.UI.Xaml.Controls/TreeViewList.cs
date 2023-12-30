using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Composable(typeof(ITreeViewListFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	public class TreeViewList : ListView, ITreeViewList
	{
	}
}
