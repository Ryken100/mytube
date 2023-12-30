using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ProgressRingAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(996758234u, 40516, 21168, 145, 223, 57, 218, 157, 193, 216, 176)]
	[WebHostHidden]
	internal interface IProgressRingAutomationPeer
	{
	}
}
