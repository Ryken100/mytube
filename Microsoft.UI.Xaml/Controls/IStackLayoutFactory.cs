using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200012E RID: 302
	[ExclusiveTo(typeof(StackLayout))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3932188550U, 8609, 23605, 145, 30, 74, 29, 232, 188, 105, 217)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IStackLayoutFactory
	{
		// Token: 0x060004DC RID: 1244
		StackLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
