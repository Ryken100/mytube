using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D1 RID: 209
	[WebHostHidden]
	[Guid(4293532378U, 37426, 21767, 163, 32, 237, 47, 173, 190, 97, 39)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationView))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface INavigationViewFactory
	{
		// Token: 0x060002FE RID: 766
		NavigationView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
