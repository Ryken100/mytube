using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000171 RID: 369
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeView))]
	[WebHostHidden]
	[Guid(1334295597U, 50752, 20688, 143, 14, 35, 89, 159, 153, 88, 175)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ITreeViewStatics2
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000645 RID: 1605
		DependencyProperty CanDragItemsProperty { get; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000646 RID: 1606
		DependencyProperty CanReorderItemsProperty { get; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000647 RID: 1607
		DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000648 RID: 1608
		DependencyProperty ItemTemplateSelectorProperty { get; }

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000649 RID: 1609
		DependencyProperty ItemContainerStyleProperty { get; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600064A RID: 1610
		DependencyProperty ItemContainerStyleSelectorProperty { get; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600064B RID: 1611
		DependencyProperty ItemContainerTransitionsProperty { get; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600064C RID: 1612
		DependencyProperty ItemsSourceProperty { get; }
	}
}
