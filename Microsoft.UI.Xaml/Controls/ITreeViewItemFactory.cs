using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000164 RID: 356
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TreeViewItem))]
	[Guid(2274351384U, 59262, 23528, 140, 138, 183, 155, 39, 176, 141, 155)]
	internal interface ITreeViewItemFactory
	{
		// Token: 0x0600061D RID: 1565
		TreeViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
