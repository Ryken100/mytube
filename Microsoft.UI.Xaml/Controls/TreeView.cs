using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200021E RID: 542
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Threading(3)]
	[WebHostHidden]
	[Static(typeof(ITreeViewStatics2), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(ITreeViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ITreeViewStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class TreeView : Control, ITreeView, ITreeView2
	{
		// Token: 0x06000B72 RID: 2930
		public extern TreeView();

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000B73 RID: 2931
		public extern IVector<TreeViewNode> RootNodes { get; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000B74 RID: 2932
		// (set) Token: 0x06000B75 RID: 2933
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		public extern TreeViewSelectionMode SelectionMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			[param: In]
			set;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000B76 RID: 2934
		public extern IVector<TreeViewNode> SelectedNodes { get; }

		// Token: 0x06000B77 RID: 2935
		public extern void Expand([In] TreeViewNode value);

		// Token: 0x06000B78 RID: 2936
		public extern void Collapse([In] TreeViewNode value);

		// Token: 0x06000B79 RID: 2937
		public extern void SelectAll();

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000B7A RID: 2938
		// (remove) Token: 0x06000B7B RID: 2939
		public extern event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> ItemInvoked;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000B7C RID: 2940
		// (remove) Token: 0x06000B7D RID: 2941
		public extern event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> Expanding;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000B7E RID: 2942
		// (remove) Token: 0x06000B7F RID: 2943
		public extern event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> Collapsed;

		// Token: 0x06000B80 RID: 2944
		public extern TreeViewNode NodeFromContainer([In] DependencyObject container);

		// Token: 0x06000B81 RID: 2945
		public extern DependencyObject ContainerFromNode([In] TreeViewNode node);

		// Token: 0x06000B82 RID: 2946
		public extern object ItemFromContainer([In] DependencyObject container);

		// Token: 0x06000B83 RID: 2947
		public extern DependencyObject ContainerFromItem([In] object item);

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000B84 RID: 2948
		// (set) Token: 0x06000B85 RID: 2949
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool CanDragItems
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000B86 RID: 2950
		// (set) Token: 0x06000B87 RID: 2951
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool CanReorderItems
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000B88 RID: 2952
		// (set) Token: 0x06000B89 RID: 2953
		public extern DataTemplate ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000B8A RID: 2954
		// (set) Token: 0x06000B8B RID: 2955
		public extern DataTemplateSelector ItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000B8C RID: 2956
		// (set) Token: 0x06000B8D RID: 2957
		public extern Style ItemContainerStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000B8E RID: 2958
		// (set) Token: 0x06000B8F RID: 2959
		public extern StyleSelector ItemContainerStyleSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000B90 RID: 2960
		// (set) Token: 0x06000B91 RID: 2961
		public extern TransitionCollection ItemContainerTransitions
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000B92 RID: 2962
		// (set) Token: 0x06000B93 RID: 2963
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

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000B94 RID: 2964
		// (remove) Token: 0x06000B95 RID: 2965
		public extern event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> DragItemsStarting;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000B96 RID: 2966
		// (remove) Token: 0x06000B97 RID: 2967
		public extern event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> DragItemsCompleted;

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000B98 RID: 2968
		// (set) Token: 0x06000B99 RID: 2969
		public extern TreeViewNode SelectedNode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000B9A RID: 2970
		// (set) Token: 0x06000B9B RID: 2971
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object SelectedItem
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000B9C RID: 2972
		public extern IVector<object> SelectedItems { get; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000B9D RID: 2973
		public static extern DependencyProperty CanDragItemsProperty { get; }

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000B9E RID: 2974
		public static extern DependencyProperty CanReorderItemsProperty { get; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000B9F RID: 2975
		public static extern DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000BA0 RID: 2976
		public static extern DependencyProperty ItemTemplateSelectorProperty { get; }

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000BA1 RID: 2977
		public static extern DependencyProperty ItemContainerStyleProperty { get; }

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000BA2 RID: 2978
		public static extern DependencyProperty ItemContainerStyleSelectorProperty { get; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000BA3 RID: 2979
		public static extern DependencyProperty ItemContainerTransitionsProperty { get; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000BA4 RID: 2980
		public static extern DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000BA5 RID: 2981
		public static extern DependencyProperty SelectedItemProperty { get; }

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000BA6 RID: 2982
		public static extern DependencyProperty SelectionModeProperty { get; }
	}
}
