using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000EC RID: 236
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(195674555U, 25884, 24419, 188, 187, 123, 223, 231, 75, 123, 56)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	internal interface INonVirtualizingLayoutContext
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000361 RID: 865
		IVectorView<UIElement> Children { get; }
	}
}
