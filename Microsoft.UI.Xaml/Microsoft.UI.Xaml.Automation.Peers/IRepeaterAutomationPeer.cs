using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(RepeaterAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(66241301u, 64341, 21682, 154, 173, 151, 35, 170, 245, 226, 207)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IRepeaterAutomationPeer
	{
	}
}
