using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000167 RID: 359
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2000482181U, 27931, 23148, 128, 29, 244, 34, 177, 168, 31, 152)]
	[ExclusiveTo(typeof(TreeViewItem))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	internal interface ITreeViewItemStatics2
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000628 RID: 1576
		DependencyProperty HasUnrealizedChildrenProperty { get; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000629 RID: 1577
		DependencyProperty ItemsSourceProperty { get; }
	}
}
