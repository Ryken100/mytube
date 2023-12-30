using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000136 RID: 310
	[ExclusiveTo(typeof(SwipeItem))]
	[WebHostHidden]
	[Guid(2033342177U, 10183, 21383, 187, 39, 83, 208, 114, 114, 54, 37)]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeItemStatics
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060004FF RID: 1279
		DependencyProperty IconSourceProperty { get; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000500 RID: 1280
		DependencyProperty TextProperty { get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000501 RID: 1281
		DependencyProperty BackgroundProperty { get; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000502 RID: 1282
		DependencyProperty ForegroundProperty { get; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000503 RID: 1283
		DependencyProperty CommandProperty { get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000504 RID: 1284
		DependencyProperty CommandParameterProperty { get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000505 RID: 1285
		DependencyProperty BehaviorOnInvokedProperty { get; }
	}
}
