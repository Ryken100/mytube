using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200016F RID: 367
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewNode))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(535796135U, 39055, 20540, 169, 25, 135, 213, 93, 201, 13, 248)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewNodeStatics
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600063F RID: 1599
		DependencyProperty ContentProperty { get; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000640 RID: 1600
		DependencyProperty DepthProperty { get; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000641 RID: 1601
		DependencyProperty IsExpandedProperty { get; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000642 RID: 1602
		DependencyProperty HasChildrenProperty { get; }
	}
}
