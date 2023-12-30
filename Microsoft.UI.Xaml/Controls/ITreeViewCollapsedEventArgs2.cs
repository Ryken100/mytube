using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015B RID: 347
	[Guid(2004896291U, 40939, 23639, 156, 149, 77, 217, 132, 38, 114, 23)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewCollapsedEventArgs))]
	internal interface ITreeViewCollapsedEventArgs2
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000601 RID: 1537
		object Item { get; }
	}
}
