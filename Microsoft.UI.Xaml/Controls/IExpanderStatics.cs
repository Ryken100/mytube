using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200009D RID: 157
	[ExclusiveTo(typeof(Expander))]
	[Guid(3359559449U, 51932, 23590, 182, 8, 17, 100, 172, 70, 193, 245)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IExpanderStatics
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001F4 RID: 500
		DependencyProperty HeaderProperty { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001F5 RID: 501
		DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001F6 RID: 502
		DependencyProperty HeaderTemplateSelectorProperty { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001F7 RID: 503
		DependencyProperty IsExpandedProperty { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001F8 RID: 504
		DependencyProperty ExpandDirectionProperty { get; }
	}
}
