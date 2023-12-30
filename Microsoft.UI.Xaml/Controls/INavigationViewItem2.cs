using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D3 RID: 211
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(760993929U, 40364, 22133, 178, 84, 104, 34, 111, 7, 122, 97)]
	[ExclusiveTo(typeof(NavigationViewItem))]
	internal interface INavigationViewItem2
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000302 RID: 770
		// (set) Token: 0x06000303 RID: 771
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool SelectsOnInvoked
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000304 RID: 772
		// (set) Token: 0x06000305 RID: 773
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000306 RID: 774
		// (set) Token: 0x06000307 RID: 775
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool HasUnrealizedChildren
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000308 RID: 776
		// (set) Token: 0x06000309 RID: 777
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		bool IsChildSelected
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600030A RID: 778
		[MUXPropertyChangedCallback(enable = true)]
		IVector<object> MenuItems
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600030B RID: 779
		// (set) Token: 0x0600030C RID: 780
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object MenuItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
