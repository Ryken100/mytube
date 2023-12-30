using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200016D RID: 365
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3639924U, 30987, 21288, 138, 250, 125, 101, 226, 45, 164, 38)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TreeViewNode))]
	internal interface ITreeViewNode
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000634 RID: 1588
		// (set) Token: 0x06000635 RID: 1589
		object Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000636 RID: 1590
		TreeViewNode Parent { get; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000637 RID: 1591
		// (set) Token: 0x06000638 RID: 1592
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000639 RID: 1593
		[MUXPropertyChangedCallback(enable = true)]
		bool HasChildren
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600063A RID: 1594
		[MUXPropertyDefaultValue(value = "-1")]
		int Depth
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600063B RID: 1595
		// (set) Token: 0x0600063C RID: 1596
		bool HasUnrealizedChildren
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600063D RID: 1597
		IVector<TreeViewNode> Children { get; }
	}
}
