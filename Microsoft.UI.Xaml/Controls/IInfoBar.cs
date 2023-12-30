using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000AB RID: 171
	[Guid(658505192U, 37668, 21943, 159, 254, 125, 153, 90, 138, 245, 107)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(InfoBar))]
	[WebHostHidden]
	internal interface IInfoBar
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600021D RID: 541
		// (set) Token: 0x0600021E RID: 542
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsOpen
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600021F RID: 543
		// (set) Token: 0x06000220 RID: 544
		string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000221 RID: 545
		// (set) Token: 0x06000222 RID: 546
		string Message
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000223 RID: 547
		// (set) Token: 0x06000224 RID: 548
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
		InfoBarSeverity Severity
		{
			[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
			[param: In]
			set;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000225 RID: 549
		// (set) Token: 0x06000226 RID: 550
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IconSource IconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000227 RID: 551
		// (set) Token: 0x06000228 RID: 552
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsIconVisible
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000229 RID: 553
		// (set) Token: 0x0600022A RID: 554
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsClosable
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600022B RID: 555
		// (set) Token: 0x0600022C RID: 556
		Style CloseButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600022D RID: 557
		// (set) Token: 0x0600022E RID: 558
		ICommand CloseButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600022F RID: 559
		// (set) Token: 0x06000230 RID: 560
		object CloseButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000231 RID: 561
		// (set) Token: 0x06000232 RID: 562
		ButtonBase ActionButton
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000233 RID: 563
		// (set) Token: 0x06000234 RID: 564
		object Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000235 RID: 565
		// (set) Token: 0x06000236 RID: 566
		DataTemplate ContentTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000237 RID: 567
		InfoBarTemplateSettings TemplateSettings { get; }

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000238 RID: 568
		// (remove) Token: 0x06000239 RID: 569
		event TypedEventHandler<InfoBar, object> CloseButtonClick;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600023A RID: 570
		// (remove) Token: 0x0600023B RID: 571
		event TypedEventHandler<InfoBar, InfoBarClosingEventArgs> Closing;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600023C RID: 572
		// (remove) Token: 0x0600023D RID: 573
		event TypedEventHandler<InfoBar, InfoBarClosedEventArgs> Closed;
	}
}
