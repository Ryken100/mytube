using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000100 RID: 256
	[ExclusiveTo(typeof(PipsPager))]
	[Guid(34022093U, 33082, 20837, 168, 153, 61, 249, 173, 205, 128, 94)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IPipsPagerFactory
	{
		// Token: 0x06000411 RID: 1041
		PipsPager CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
