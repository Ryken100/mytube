using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200021F RID: 543
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class TreeViewCollapsedEventArgs : ITreeViewCollapsedEventArgs, ITreeViewCollapsedEventArgs2
	{
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000BA7 RID: 2983
		public extern TreeViewNode Node { get; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000BA8 RID: 2984
		public extern object Item { get; }
	}
}
