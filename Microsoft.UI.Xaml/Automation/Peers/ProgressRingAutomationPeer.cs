using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000047 RID: 71
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IProgressRingAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public class ProgressRingAutomationPeer : FrameworkElementAutomationPeer, IProgressRingAutomationPeer, IRangeValueProvider
	{
		// Token: 0x06000039 RID: 57
		public extern ProgressRingAutomationPeer([In] ProgressRing owner);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003A RID: 58
		public extern bool IsReadOnly { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003B RID: 59
		public extern double LargeChange { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60
		public extern double Maximum { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61
		public extern double Minimum { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62
		public extern double SmallChange { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003F RID: 63
		public extern double Value { get; }

		// Token: 0x06000040 RID: 64
		public extern void SetValue([In] double value);
	}
}
