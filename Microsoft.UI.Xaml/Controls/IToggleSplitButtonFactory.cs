using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000155 RID: 341
	[ExclusiveTo(typeof(ToggleSplitButton))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(625319170U, 4092, 23676, 175, 86, 245, 90, 173, 109, 181, 231)]
	internal interface IToggleSplitButtonFactory
	{
		// Token: 0x060005D4 RID: 1492
		ToggleSplitButton CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
