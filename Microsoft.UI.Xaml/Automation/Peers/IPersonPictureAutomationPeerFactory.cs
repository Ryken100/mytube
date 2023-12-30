using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000021 RID: 33
	[ExclusiveTo(typeof(PersonPictureAutomationPeer))]
	[WebHostHidden]
	[Guid(3172403685U, 6464, 22268, 181, 195, 133, 228, 87, 9, 81, 204)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IPersonPictureAutomationPeerFactory
	{
		// Token: 0x0600001A RID: 26
		PersonPictureAutomationPeer CreateInstanceWithOwner([In] PersonPicture owner, [In] object baseInterface, out object innerInterface);
	}
}
