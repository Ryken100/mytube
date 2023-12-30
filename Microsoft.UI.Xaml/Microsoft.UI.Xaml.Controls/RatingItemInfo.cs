using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Composable(typeof(IRatingItemInfoFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public class RatingItemInfo : DependencyObject, IRatingItemInfo
	{
	}
}
