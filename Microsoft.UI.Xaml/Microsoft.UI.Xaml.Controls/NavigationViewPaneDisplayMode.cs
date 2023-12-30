using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public enum NavigationViewPaneDisplayMode
	{
		Auto,
		Left,
		Top,
		LeftCompact,
		LeftMinimal
	}
}
