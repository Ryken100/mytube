using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000132 RID: 306
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(3188634904U, 16564, 23789, 141, 251, 108, 160, 24, 241, 202, 202)]
	[ExclusiveTo(typeof(SwipeControl))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface ISwipeControlStatics
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060004E9 RID: 1257
		DependencyProperty LeftItemsProperty { get; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060004EA RID: 1258
		DependencyProperty RightItemsProperty { get; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060004EB RID: 1259
		DependencyProperty TopItemsProperty { get; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060004EC RID: 1260
		DependencyProperty BottomItemsProperty { get; }
	}
}
