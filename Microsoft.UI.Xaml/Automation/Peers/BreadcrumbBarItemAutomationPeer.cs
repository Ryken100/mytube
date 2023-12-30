using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000003 RID: 3
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IBreadcrumbBarItemAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class BreadcrumbBarItemAutomationPeer : FrameworkElementAutomationPeer, IBreadcrumbBarItemAutomationPeer, IInvokeProvider
	{
		// Token: 0x06000002 RID: 2
		public extern BreadcrumbBarItemAutomationPeer([In] BreadcrumbBarItem owner);

		// Token: 0x06000003 RID: 3
		public extern void Invoke();
	}
}
