using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200001F RID: 31
	[ExclusiveTo(typeof(NumberBoxAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1704401324U, 17413, 22772, 189, 226, 239, 97, 223, 230, 76, 33)]
	[WebHostHidden]
	internal interface INumberBoxAutomationPeerFactory
	{
		// Token: 0x06000019 RID: 25
		NumberBoxAutomationPeer CreateInstance([In] NumberBox owner, [In] object baseInterface, out object innerInterface);
	}
}
