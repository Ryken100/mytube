using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000087 RID: 135
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(BreadcrumbBar))]
	[Guid(776452054U, 24509, 21703, 176, 177, 206, 255, 74, 25, 199, 68)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IBreadcrumbBar
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600018A RID: 394
		// (set) Token: 0x0600018B RID: 395
		object ItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600018C RID: 396
		// (set) Token: 0x0600018D RID: 397
		object ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600018E RID: 398
		// (remove) Token: 0x0600018F RID: 399
		event TypedEventHandler<BreadcrumbBar, BreadcrumbBarItemClickedEventArgs> ItemClicked;
	}
}
