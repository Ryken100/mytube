using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F9 RID: 249
	[ExclusiveTo(typeof(PathIconSource))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2683298590U, 23222, 21396, 166, 239, 103, 47, 23, 77, 51, 59)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IPathIconSourceFactory
	{
		// Token: 0x060003D6 RID: 982
		PathIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
