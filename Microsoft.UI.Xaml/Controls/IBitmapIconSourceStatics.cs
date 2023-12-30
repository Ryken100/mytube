using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000086 RID: 134
	[Guid(2120235862U, 21888, 23195, 144, 13, 5, 100, 22, 42, 95, 55)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(BitmapIconSource))]
	internal interface IBitmapIconSourceStatics
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000188 RID: 392
		DependencyProperty UriSourceProperty { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000189 RID: 393
		DependencyProperty ShowAsMonochromeProperty { get; }
	}
}
