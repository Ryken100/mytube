using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000207 RID: 519
	[Threading(3)]
	[Static(typeof(ISwipeItemsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Composable(typeof(ISwipeItemsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class SwipeItems : DependencyObject, ISwipeItems, IVector<SwipeItem>, IIterable<SwipeItem>
	{
		// Token: 0x06000A95 RID: 2709
		public extern SwipeItems();

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000A96 RID: 2710
		// (set) Token: 0x06000A97 RID: 2711
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern SwipeMode Mode
		{
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x06000A98 RID: 2712
		public extern SwipeItem GetAt([In] uint index);

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000A99 RID: 2713
		public extern uint Size { get; }

		// Token: 0x06000A9A RID: 2714
		public extern IVectorView<SwipeItem> GetView();

		// Token: 0x06000A9B RID: 2715
		public extern bool IndexOf([In] SwipeItem value, out uint index);

		// Token: 0x06000A9C RID: 2716
		public extern void SetAt([In] uint index, [In] SwipeItem value);

		// Token: 0x06000A9D RID: 2717
		public extern void InsertAt([In] uint index, [In] SwipeItem value);

		// Token: 0x06000A9E RID: 2718
		public extern void RemoveAt([In] uint index);

		// Token: 0x06000A9F RID: 2719
		public extern void Append([In] SwipeItem value);

		// Token: 0x06000AA0 RID: 2720
		public extern void RemoveAtEnd();

		// Token: 0x06000AA1 RID: 2721
		public extern void Clear();

		// Token: 0x06000AA2 RID: 2722
		public extern uint GetMany([In] uint startIndex, [Out] SwipeItem[] items);

		// Token: 0x06000AA3 RID: 2723
		public extern void ReplaceAll([In] SwipeItem[] items);

		// Token: 0x06000AA4 RID: 2724
		public extern IIterator<SwipeItem> First();

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000AA5 RID: 2725
		public static extern DependencyProperty ModeProperty { get; }
	}
}
