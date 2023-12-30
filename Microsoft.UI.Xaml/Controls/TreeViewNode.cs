using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000227 RID: 551
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Composable(typeof(ITreeViewNodeFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Bindable]
	[Static(typeof(ITreeViewNodeStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TreeViewNode : DependencyObject, ITreeViewNode
	{
		// Token: 0x06000BDA RID: 3034
		public extern TreeViewNode();

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06000BDB RID: 3035
		// (set) Token: 0x06000BDC RID: 3036
		public extern object Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06000BDD RID: 3037
		public extern TreeViewNode Parent { get; }

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000BDE RID: 3038
		// (set) Token: 0x06000BDF RID: 3039
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06000BE0 RID: 3040
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool HasChildren
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06000BE1 RID: 3041
		[MUXPropertyDefaultValue(value = "-1")]
		public extern int Depth
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000BE2 RID: 3042
		// (set) Token: 0x06000BE3 RID: 3043
		public extern bool HasUnrealizedChildren
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06000BE4 RID: 3044
		public extern IVector<TreeViewNode> Children { get; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06000BE5 RID: 3045
		public static extern DependencyProperty ContentProperty { get; }

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06000BE6 RID: 3046
		public static extern DependencyProperty DepthProperty { get; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06000BE7 RID: 3047
		public static extern DependencyProperty IsExpandedProperty { get; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06000BE8 RID: 3048
		public static extern DependencyProperty HasChildrenProperty { get; }
	}
}
