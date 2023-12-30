using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000085 RID: 133
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(BitmapIconSource))]
	[WebHostHidden]
	[Guid(2101890068U, 62966, 24121, 180, 228, 182, 16, 141, 46, 224, 149)]
	internal interface IBitmapIconSourceFactory
	{
		// Token: 0x06000187 RID: 391
		BitmapIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
