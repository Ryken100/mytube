using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A8 RID: 168
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ImageIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(620192545U, 29117, 21258, 140, 200, 63, 97, 92, 209, 67, 122)]
	internal interface IImageIconSourceFactory
	{
		// Token: 0x0600021A RID: 538
		ImageIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
