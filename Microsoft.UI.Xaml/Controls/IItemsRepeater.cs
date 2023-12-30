using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B5 RID: 181
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ItemsRepeater))]
	[WebHostHidden]
	[Guid(198743282U, 60924, 24031, 161, 102, 45, 177, 75, 191, 223, 53)]
	internal interface IItemsRepeater
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000255 RID: 597
		// (set) Token: 0x06000256 RID: 598
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object ItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000257 RID: 599
		ItemsSourceView ItemsSourceView { get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000258 RID: 600
		// (set) Token: 0x06000259 RID: 601
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object ItemTemplate
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600025A RID: 602
		// (set) Token: 0x0600025B RID: 603
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyChangedCallback(enable = true)]
		Layout Layout
		{
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[param: In]
			set;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600025C RID: 604
		// (set) Token: 0x0600025D RID: 605
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyDefaultValue(value = "2.0")]
		double HorizontalCacheLength
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			get;
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600025E RID: 606
		// (set) Token: 0x0600025F RID: 607
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		double VerticalCacheLength
		{
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000260 RID: 608
		// (set) Token: 0x06000261 RID: 609
		Brush Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000262 RID: 610
		int GetElementIndex([In] UIElement element);

		// Token: 0x06000263 RID: 611
		UIElement TryGetElement([In] int index);

		// Token: 0x06000264 RID: 612
		UIElement GetOrCreateElement([In] int index);

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000265 RID: 613
		// (remove) Token: 0x06000266 RID: 614
		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ElementPrepared;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000267 RID: 615
		// (remove) Token: 0x06000268 RID: 616
		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ElementClearing;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000269 RID: 617
		// (remove) Token: 0x0600026A RID: 618
		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged;
	}
}
