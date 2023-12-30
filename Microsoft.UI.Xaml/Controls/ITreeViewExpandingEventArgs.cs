using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015F RID: 351
	[Guid(3178667767U, 51932, 21300, 147, 173, 201, 187, 232, 32, 100, 61)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewExpandingEventArgs))]
	internal interface ITreeViewExpandingEventArgs
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000609 RID: 1545
		TreeViewNode Node { get; }
	}
}
