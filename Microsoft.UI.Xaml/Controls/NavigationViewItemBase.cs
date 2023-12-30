using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019A RID: 410
	[Composable(typeof(INavigationViewItemBaseFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Static(typeof(INavigationViewItemBaseStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Threading(3)]
	public class NavigationViewItemBase : ContentControl, INavigationViewItemBase, INavigationViewItemBase2
	{
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060007B2 RID: 1970
		// (set) Token: 0x060007B3 RID: 1971
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsSelected
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060007B4 RID: 1972
		public static extern DependencyProperty IsSelectedProperty { get; }
	}
}
