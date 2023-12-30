using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200016C RID: 364
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(1175755168U, 26831, 23425, 176, 228, 177, 175, 146, 155, 11, 18)]
	[ExclusiveTo(typeof(TreeViewList))]
	internal interface ITreeViewListFactory
	{
		// Token: 0x06000633 RID: 1587
		TreeViewList CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
