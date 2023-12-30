using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	public enum NavigationViewSelectionFollowsFocus
	{
		Disabled,
		Enabled
	}
}
