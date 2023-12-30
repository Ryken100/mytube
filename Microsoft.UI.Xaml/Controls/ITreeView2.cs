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
	// Token: 0x02000159 RID: 345
	[Guid(2830019266U, 36163, 22750, 167, 53, 98, 104, 183, 172, 149, 71)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TreeView))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeView2
	{
		// Token: 0x060005E3 RID: 1507
		TreeViewNode NodeFromContainer([In] DependencyObject container);

		// Token: 0x060005E4 RID: 1508
		DependencyObject ContainerFromNode([In] TreeViewNode node);

		// Token: 0x060005E5 RID: 1509
		object ItemFromContainer([In] DependencyObject container);

		// Token: 0x060005E6 RID: 1510
		DependencyObject ContainerFromItem([In] object item);

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060005E7 RID: 1511
		// (set) Token: 0x060005E8 RID: 1512
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool CanDragItems
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060005E9 RID: 1513
		// (set) Token: 0x060005EA RID: 1514
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool CanReorderItems
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060005EB RID: 1515
		// (set) Token: 0x060005EC RID: 1516
		DataTemplate ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060005ED RID: 1517
		// (set) Token: 0x060005EE RID: 1518
		DataTemplateSelector ItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060005EF RID: 1519
		// (set) Token: 0x060005F0 RID: 1520
		Style ItemContainerStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060005F1 RID: 1521
		// (set) Token: 0x060005F2 RID: 1522
		StyleSelector ItemContainerStyleSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060005F3 RID: 1523
		// (set) Token: 0x060005F4 RID: 1524
		TransitionCollection ItemContainerTransitions
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060005F5 RID: 1525
		// (set) Token: 0x060005F6 RID: 1526
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

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060005F7 RID: 1527
		// (remove) Token: 0x060005F8 RID: 1528
		event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> DragItemsStarting;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060005F9 RID: 1529
		// (remove) Token: 0x060005FA RID: 1530
		event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> DragItemsCompleted;

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060005FB RID: 1531
		// (set) Token: 0x060005FC RID: 1532
		TreeViewNode SelectedNode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060005FD RID: 1533
		// (set) Token: 0x060005FE RID: 1534
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object SelectedItem
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060005FF RID: 1535
		IVector<object> SelectedItems { get; }
	}
}
