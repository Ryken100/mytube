using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000249 RID: 585
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(1185501019U, 35517, 21873, 176, 73, 127, 118, 227, 249, 103, 201)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RevealBrush))]
	[WebHostHidden]
	internal interface IRevealBrushProtectedFactory
	{
		// Token: 0x06000C85 RID: 3205
		RevealBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
