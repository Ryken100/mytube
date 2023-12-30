using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000044 RID: 68
	[Composable(typeof(IPersonPictureAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class PersonPictureAutomationPeer : FrameworkElementAutomationPeer, IPersonPictureAutomationPeer
	{
		// Token: 0x06000036 RID: 54
		public extern PersonPictureAutomationPeer([In] PersonPicture owner);
	}
}
