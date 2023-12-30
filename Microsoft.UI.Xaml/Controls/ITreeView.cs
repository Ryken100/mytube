using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000158 RID: 344
	[ExclusiveTo(typeof(TreeView))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(468687604U, 28972, 20719, 155, 180, 136, 27, 151, 82, 50, 171)]
	[WebHostHidden]
	internal interface ITreeView
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060005D6 RID: 1494
		IVector<TreeViewNode> RootNodes { get; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060005D7 RID: 1495
		// (set) Token: 0x060005D8 RID: 1496
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		TreeViewSelectionMode SelectionMode
		{
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060005D9 RID: 1497
		IVector<TreeViewNode> SelectedNodes { get; }

		// Token: 0x060005DA RID: 1498
		void Expand([In] TreeViewNode value);

		// Token: 0x060005DB RID: 1499
		void Collapse([In] TreeViewNode value);

		// Token: 0x060005DC RID: 1500
		void SelectAll();

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060005DD RID: 1501
		// (remove) Token: 0x060005DE RID: 1502
		event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> ItemInvoked;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060005DF RID: 1503
		// (remove) Token: 0x060005E0 RID: 1504
		event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> Expanding;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060005E1 RID: 1505
		// (remove) Token: 0x060005E2 RID: 1506
		event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> Collapsed;
	}
}
