using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000009 RID: 9
	[ExclusiveTo(typeof(AnimatedVisualPlayerAutomationPeer))]
	[Guid(3534000536U, 32955, 20950, 180, 149, 61, 197, 170, 181, 149, 137)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAnimatedVisualPlayerAutomationPeerFactory
	{
		// Token: 0x0600000E RID: 14
		AnimatedVisualPlayerAutomationPeer CreateInstance([In] AnimatedVisualPlayer owner, [In] object baseInterface, out object innerInterface);
	}
}
