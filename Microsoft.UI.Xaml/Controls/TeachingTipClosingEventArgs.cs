using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000216 RID: 534
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class TeachingTipClosingEventArgs : ITeachingTipClosingEventArgs
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000B5D RID: 2909
		public extern TeachingTipCloseReason Reason { get; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000B5E RID: 2910
		// (set) Token: 0x06000B5F RID: 2911
		public extern bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000B60 RID: 2912
		public extern Deferral GetDeferral();
	}
}
