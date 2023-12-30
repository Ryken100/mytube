using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D2 RID: 210
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Guid(338896075U, 47948, 21089, 173, 152, 163, 27, 75, 87, 160, 204)]
	internal interface INavigationViewItem
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060002FF RID: 767
		// (set) Token: 0x06000300 RID: 768
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IconElement Icon
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000301 RID: 769
		[MUXPropertyDefaultValue(value = "48.0")]
		double CompactPaneLength
		{
			[MUXPropertyDefaultValue(value = "48.0")]
			get;
		}
	}
}
