using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018A RID: 394
	[Static(typeof(IItemsRepeaterStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "ItemTemplate")]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(2)]
	[Composable(typeof(IItemsRepeaterFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class ItemsRepeater : FrameworkElement, IItemsRepeater
	{
		// Token: 0x060006E2 RID: 1762
		public extern ItemsRepeater();

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060006E3 RID: 1763
		// (set) Token: 0x060006E4 RID: 1764
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object ItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060006E5 RID: 1765
		public extern ItemsSourceView ItemsSourceView { get; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060006E6 RID: 1766
		// (set) Token: 0x060006E7 RID: 1767
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object ItemTemplate
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060006E8 RID: 1768
		// (set) Token: 0x060006E9 RID: 1769
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Layout Layout
		{
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060006EA RID: 1770
		// (set) Token: 0x060006EB RID: 1771
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		public extern double HorizontalCacheLength
		{
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[param: In]
			set;
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060006EC RID: 1772
		// (set) Token: 0x060006ED RID: 1773
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		public extern double VerticalCacheLength
		{
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[param: In]
			set;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060006EE RID: 1774
		// (set) Token: 0x060006EF RID: 1775
		public extern Brush Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x060006F0 RID: 1776
		public extern int GetElementIndex([In] UIElement element);

		// Token: 0x060006F1 RID: 1777
		public extern UIElement TryGetElement([In] int index);

		// Token: 0x060006F2 RID: 1778
		public extern UIElement GetOrCreateElement([In] int index);

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060006F3 RID: 1779
		// (remove) Token: 0x060006F4 RID: 1780
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ElementPrepared;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060006F5 RID: 1781
		// (remove) Token: 0x060006F6 RID: 1782
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ElementClearing;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060006F7 RID: 1783
		// (remove) Token: 0x060006F8 RID: 1784
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged;

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060006F9 RID: 1785
		public static extern DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060006FA RID: 1786
		public static extern DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060006FB RID: 1787
		public static extern DependencyProperty LayoutProperty { get; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060006FC RID: 1788
		public static extern DependencyProperty HorizontalCacheLengthProperty { get; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060006FD RID: 1789
		public static extern DependencyProperty VerticalCacheLengthProperty { get; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060006FE RID: 1790
		public static extern DependencyProperty BackgroundProperty { get; }
	}
}
