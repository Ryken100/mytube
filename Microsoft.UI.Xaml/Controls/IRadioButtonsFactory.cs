using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010D RID: 269
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Guid(754540283U, 42914, 23941, 142, 173, 234, 34, 43, 170, 60, 85)]
	[ExclusiveTo(typeof(RadioButtons))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IRadioButtonsFactory
	{
		// Token: 0x06000459 RID: 1113
		RadioButtons CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
