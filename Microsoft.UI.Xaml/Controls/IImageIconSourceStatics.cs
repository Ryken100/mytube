using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A9 RID: 169
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2597950298U, 36249, 22058, 133, 106, 200, 186, 23, 130, 61, 35)]
	[ExclusiveTo(typeof(ImageIconSource))]
	internal interface IImageIconSourceStatics
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600021B RID: 539
		DependencyProperty ImageSourceProperty { get; }
	}
}
