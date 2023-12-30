using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F0 RID: 240
	[ExclusiveTo(typeof(NonVirtualizingLayout))]
	[WebHostHidden]
	[Guid(1009301553U, 13761, 20866, 168, 67, 164, 63, 51, 155, 102, 135)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INonVirtualizingLayoutOverrides
	{
		// Token: 0x06000365 RID: 869
		void InitializeForContextCore([In] NonVirtualizingLayoutContext context);

		// Token: 0x06000366 RID: 870
		void UninitializeForContextCore([In] NonVirtualizingLayoutContext context);

		// Token: 0x06000367 RID: 871
		Size MeasureOverride([In] NonVirtualizingLayoutContext context, [In] Size availableSize);

		// Token: 0x06000368 RID: 872
		Size ArrangeOverride([In] NonVirtualizingLayoutContext context, [In] Size finalSize);
	}
}
