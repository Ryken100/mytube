using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000133 RID: 307
	[Guid(1443882693U, 4255, 22630, 176, 46, 49, 228, 250, 147, 14, 208)]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(SwipeItem))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ISwipeItem
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060004ED RID: 1261
		// (set) Token: 0x060004EE RID: 1262
		string Text
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060004EF RID: 1263
		// (set) Token: 0x060004F0 RID: 1264
		IconSource IconSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060004F1 RID: 1265
		// (set) Token: 0x060004F2 RID: 1266
		Brush Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060004F3 RID: 1267
		// (set) Token: 0x060004F4 RID: 1268
		Brush Foreground
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060004F5 RID: 1269
		// (set) Token: 0x060004F6 RID: 1270
		ICommand Command
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060004F7 RID: 1271
		// (set) Token: 0x060004F8 RID: 1272
		object CommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060004F9 RID: 1273
		// (set) Token: 0x060004FA RID: 1274
		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		SwipeBehaviorOnInvoked BehaviorOnInvoked
		{
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			[param: In]
			set;
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060004FB RID: 1275
		// (remove) Token: 0x060004FC RID: 1276
		event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked;
	}
}
