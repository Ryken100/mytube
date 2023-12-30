using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000088 RID: 136
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(BreadcrumbBar))]
	[Guid(3585517273U, 12616, 23740, 166, 174, 15, 68, 205, 228, 25, 82)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IBreadcrumbBarFactory
	{
		// Token: 0x06000190 RID: 400
		BreadcrumbBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
