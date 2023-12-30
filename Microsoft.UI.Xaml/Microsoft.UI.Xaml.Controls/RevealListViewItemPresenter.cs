using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[Composable(typeof(IRevealListViewItemPresenterFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class RevealListViewItemPresenter : ListViewItemPresenter, IRevealListViewItemPresenter
	{
	}
}
