using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000184 RID: 388
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Static(typeof(IInfoBarStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContentProperty(Name = "Content")]
	[Composable(typeof(IInfoBarFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class InfoBar : Control, IInfoBar
	{
		// Token: 0x060006AA RID: 1706
		public extern InfoBar();

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060006AB RID: 1707
		// (set) Token: 0x060006AC RID: 1708
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsOpen
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060006AD RID: 1709
		// (set) Token: 0x060006AE RID: 1710
		public extern string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060006AF RID: 1711
		// (set) Token: 0x060006B0 RID: 1712
		public extern string Message
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060006B1 RID: 1713
		// (set) Token: 0x060006B2 RID: 1714
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
		[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern InfoBarSeverity Severity
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::InfoBarSeverity::Informational")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060006B3 RID: 1715
		// (set) Token: 0x060006B4 RID: 1716
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IconSource IconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060006B5 RID: 1717
		// (set) Token: 0x060006B6 RID: 1718
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsIconVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060006B7 RID: 1719
		// (set) Token: 0x060006B8 RID: 1720
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsClosable
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060006B9 RID: 1721
		// (set) Token: 0x060006BA RID: 1722
		public extern Style CloseButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060006BB RID: 1723
		// (set) Token: 0x060006BC RID: 1724
		public extern ICommand CloseButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060006BD RID: 1725
		// (set) Token: 0x060006BE RID: 1726
		public extern object CloseButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060006BF RID: 1727
		// (set) Token: 0x060006C0 RID: 1728
		public extern ButtonBase ActionButton
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060006C1 RID: 1729
		// (set) Token: 0x060006C2 RID: 1730
		public extern object Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060006C3 RID: 1731
		// (set) Token: 0x060006C4 RID: 1732
		public extern DataTemplate ContentTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060006C5 RID: 1733
		public extern InfoBarTemplateSettings TemplateSettings { get; }

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060006C6 RID: 1734
		// (remove) Token: 0x060006C7 RID: 1735
		public extern event TypedEventHandler<InfoBar, object> CloseButtonClick;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060006C8 RID: 1736
		// (remove) Token: 0x060006C9 RID: 1737
		public extern event TypedEventHandler<InfoBar, InfoBarClosingEventArgs> Closing;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060006CA RID: 1738
		// (remove) Token: 0x060006CB RID: 1739
		public extern event TypedEventHandler<InfoBar, InfoBarClosedEventArgs> Closed;

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060006CC RID: 1740
		public static extern DependencyProperty IsOpenProperty { get; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060006CD RID: 1741
		public static extern DependencyProperty TitleProperty { get; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060006CE RID: 1742
		public static extern DependencyProperty MessageProperty { get; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060006CF RID: 1743
		public static extern DependencyProperty SeverityProperty { get; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060006D0 RID: 1744
		public static extern DependencyProperty IconSourceProperty { get; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060006D1 RID: 1745
		public static extern DependencyProperty IsIconVisibleProperty { get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060006D2 RID: 1746
		public static extern DependencyProperty IsClosableProperty { get; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060006D3 RID: 1747
		public static extern DependencyProperty CloseButtonStyleProperty { get; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060006D4 RID: 1748
		public static extern DependencyProperty CloseButtonCommandProperty { get; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060006D5 RID: 1749
		public static extern DependencyProperty CloseButtonCommandParameterProperty { get; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060006D6 RID: 1750
		public static extern DependencyProperty ActionButtonProperty { get; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060006D7 RID: 1751
		public static extern DependencyProperty ContentProperty { get; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060006D8 RID: 1752
		public static extern DependencyProperty ContentTemplateProperty { get; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060006D9 RID: 1753
		public static extern DependencyProperty TemplateSettingsProperty { get; }
	}
}
