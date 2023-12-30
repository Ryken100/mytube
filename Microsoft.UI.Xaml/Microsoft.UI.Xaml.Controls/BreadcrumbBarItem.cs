using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IBreadcrumbBarItemFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class BreadcrumbBarItem : ContentControl, IBreadcrumbBarItem
	{
	}
}
