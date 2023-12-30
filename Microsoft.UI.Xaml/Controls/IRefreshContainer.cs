using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200011E RID: 286
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(479688936U, 42023, 24454, 157, 94, 2, 219, 155, 44, 64, 147)]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(RefreshContainer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IRefreshContainer
	{
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060004AE RID: 1198
		// (set) Token: 0x060004AF RID: 1199
		RefreshVisualizer Visualizer
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060004B0 RID: 1200
		// (set) Token: 0x060004B1 RID: 1201
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		RefreshPullDirection PullDirection
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			[param: In]
			set;
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060004B2 RID: 1202
		// (remove) Token: 0x060004B3 RID: 1203
		event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

		// Token: 0x060004B4 RID: 1204
		void RequestRefresh();
	}
}
