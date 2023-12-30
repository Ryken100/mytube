using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008C RID: 140
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[Guid(2514135788U, 57892, 22188, 151, 73, 78, 221, 172, 12, 48, 67)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(BreadcrumbBar))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IBreadcrumbBarStatics
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000194 RID: 404
		DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000195 RID: 405
		DependencyProperty ItemTemplateProperty { get; }
	}
}
