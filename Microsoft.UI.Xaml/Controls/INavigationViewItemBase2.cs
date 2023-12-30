using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D5 RID: 213
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3645826691U, 54327, 21795, 156, 92, 17, 212, 128, 78, 71, 30)]
	[ExclusiveTo(typeof(NavigationViewItemBase))]
	[WebHostHidden]
	internal interface INavigationViewItemBase2
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600030D RID: 781
		// (set) Token: 0x0600030E RID: 782
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsSelected
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
