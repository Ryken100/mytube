using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000222 RID: 546
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public sealed class TreeViewExpandingEventArgs : ITreeViewExpandingEventArgs, ITreeViewExpandingEventArgs2
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000BB0 RID: 2992
		public extern TreeViewNode Node { get; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000BB1 RID: 2993
		public extern object Item { get; }
	}
}
