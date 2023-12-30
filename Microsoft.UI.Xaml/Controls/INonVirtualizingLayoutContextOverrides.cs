using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000EE RID: 238
	[WebHostHidden]
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	[Guid(4174665887U, 45963, 23561, 131, 86, 199, 62, 207, 182, 238, 216)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INonVirtualizingLayoutContextOverrides
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000363 RID: 867
		IVectorView<UIElement> ChildrenCore { get; }
	}
}
