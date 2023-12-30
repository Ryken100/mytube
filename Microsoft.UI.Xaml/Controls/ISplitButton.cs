using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000129 RID: 297
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2332622954U, 25153, 22863, 147, 228, 139, 240, 81, 215, 186, 143)]
	[ExclusiveTo(typeof(SplitButton))]
	[WebHostHidden]
	internal interface ISplitButton
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060004CC RID: 1228
		// (set) Token: 0x060004CD RID: 1229
		FlyoutBase Flyout
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060004CE RID: 1230
		// (set) Token: 0x060004CF RID: 1231
		ICommand Command
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060004D0 RID: 1232
		// (set) Token: 0x060004D1 RID: 1233
		object CommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060004D2 RID: 1234
		// (remove) Token: 0x060004D3 RID: 1235
		event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> Click;
	}
}
