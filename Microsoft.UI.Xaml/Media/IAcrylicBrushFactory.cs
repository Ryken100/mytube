using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200023E RID: 574
	[ExclusiveTo(typeof(AcrylicBrush))]
	[Guid(2149004115U, 24861, 23042, 136, 100, 26, 170, 39, 157, 255, 28)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAcrylicBrushFactory
	{
		// Token: 0x06000C5F RID: 3167
		AcrylicBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
