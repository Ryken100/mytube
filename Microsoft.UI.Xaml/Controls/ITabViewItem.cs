using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013F RID: 319
	[WebHostHidden]
	[ExclusiveTo(typeof(TabViewItem))]
	[Guid(689913496U, 20247, 20513, 148, 240, 106, 91, 48, 67, 18, 182)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITabViewItem
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000546 RID: 1350
		// (set) Token: 0x06000547 RID: 1351
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object Header
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000548 RID: 1352
		// (set) Token: 0x06000549 RID: 1353
		DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600054A RID: 1354
		// (set) Token: 0x0600054B RID: 1355
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IconSource IconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600054C RID: 1356
		// (set) Token: 0x0600054D RID: 1357
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsClosable
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600054E RID: 1358
		TabViewItemTemplateSettings TabViewTemplateSettings { get; }

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600054F RID: 1359
		// (remove) Token: 0x06000550 RID: 1360
		event TypedEventHandler<TabViewItem, TabViewTabCloseRequestedEventArgs> CloseRequested;
	}
}
