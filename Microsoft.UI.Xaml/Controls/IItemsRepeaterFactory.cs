using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B9 RID: 185
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(3284267588U, 26536, 22159, 166, 247, 93, 168, 176, 234, 221, 73)]
	[ExclusiveTo(typeof(ItemsRepeater))]
	internal interface IItemsRepeaterFactory
	{
		// Token: 0x06000271 RID: 625
		ItemsRepeater CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
