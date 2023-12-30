using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000210 RID: 528
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class TabViewTabDragStartingEventArgs : ITabViewTabDragStartingEventArgs
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000B0E RID: 2830
		// (set) Token: 0x06000B0F RID: 2831
		public extern bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000B10 RID: 2832
		public extern DataPackage Data { get; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000B11 RID: 2833
		public extern object Item { get; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000B12 RID: 2834
		public extern TabViewItem Tab { get; }
	}
}
