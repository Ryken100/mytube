using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000221 RID: 545
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class TreeViewDragItemsStartingEventArgs : ITreeViewDragItemsStartingEventArgs
	{
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000BAC RID: 2988
		// (set) Token: 0x06000BAD RID: 2989
		public extern bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000BAE RID: 2990
		public extern DataPackage Data { get; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000BAF RID: 2991
		public extern IVector<object> Items { get; }
	}
}
