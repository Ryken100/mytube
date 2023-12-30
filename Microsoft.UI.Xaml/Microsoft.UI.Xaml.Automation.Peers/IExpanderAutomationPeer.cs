using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ExpanderAutomationPeer))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(4149376008u, 52361, 23397, 187, 222, 234, 230, 214, 109, 195, 229)]
	internal interface IExpanderAutomationPeer
	{
	}
}
