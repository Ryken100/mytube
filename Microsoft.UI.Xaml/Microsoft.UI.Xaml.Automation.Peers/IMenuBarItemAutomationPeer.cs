using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBarItemAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(766021837u, 2734, 21433, 140, 18, 129, 0, 63, 96, 237, 20)]
	internal interface IMenuBarItemAutomationPeer
	{
	}
}
