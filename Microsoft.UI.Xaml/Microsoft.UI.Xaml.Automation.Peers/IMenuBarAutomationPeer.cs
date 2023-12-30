using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(MenuBarAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2929125136u, 47571, 23005, 151, 62, 27, 188, 134, 207, 10, 252)]
	internal interface IMenuBarAutomationPeer
	{
	}
}
