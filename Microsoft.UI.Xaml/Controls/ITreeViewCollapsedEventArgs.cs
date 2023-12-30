using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015A RID: 346
	[ExclusiveTo(typeof(TreeViewCollapsedEventArgs))]
	[WebHostHidden]
	[Guid(2397047641U, 17094, 23923, 128, 159, 104, 113, 0, 136, 229, 165)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewCollapsedEventArgs
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000600 RID: 1536
		TreeViewNode Node { get; }
	}
}
