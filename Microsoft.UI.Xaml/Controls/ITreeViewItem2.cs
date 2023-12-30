using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000163 RID: 355
	[ExclusiveTo(typeof(TreeViewItem))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2981560643U, 16219, 21748, 139, 215, 65, 220, 21, 207, 69, 169)]
	[WebHostHidden]
	internal interface ITreeViewItem2
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000619 RID: 1561
		// (set) Token: 0x0600061A RID: 1562
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool HasUnrealizedChildren
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600061B RID: 1563
		// (set) Token: 0x0600061C RID: 1564
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
	}
}
