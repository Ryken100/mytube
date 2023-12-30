using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A4 RID: 164
	[ExclusiveTo(typeof(IconSource))]
	[Guid(1302674102U, 35141, 22059, 161, 165, 250, 181, 226, 232, 213, 117)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IIconSourceStatics
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000214 RID: 532
		DependencyProperty ForegroundProperty { get; }
	}
}
