using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000139 RID: 313
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2027189911U, 60146, 22098, 154, 252, 215, 19, 202, 16, 52, 136)]
	[ExclusiveTo(typeof(SwipeItems))]
	internal interface ISwipeItemsStatics
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000509 RID: 1289
		DependencyProperty ModeProperty { get; }
	}
}
