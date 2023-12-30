using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200021C RID: 540
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Static(typeof(IToggleSplitButtonStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IToggleSplitButtonFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	public class ToggleSplitButton : SplitButton, IToggleSplitButton
	{
		// Token: 0x06000B6C RID: 2924
		public extern ToggleSplitButton();

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000B6D RID: 2925
		// (set) Token: 0x06000B6E RID: 2926
		public extern bool IsChecked
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000B6F RID: 2927
		// (remove) Token: 0x06000B70 RID: 2928
		public extern event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000B71 RID: 2929
		public static extern DependencyProperty IsCheckedProperty { get; }
	}
}
