using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200011F RID: 287
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RefreshContainer))]
	[Guid(1596100513U, 11938, 21173, 183, 138, 12, 19, 63, 134, 240, 32)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRefreshContainerFactory
	{
		// Token: 0x060004B5 RID: 1205
		RefreshContainer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
