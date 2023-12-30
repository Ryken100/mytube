using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200017B RID: 379
	[WebHostHidden]
	[ExclusiveTo(typeof(VirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2580528080U, 44137, 21740, 145, 238, 39, 212, 134, 77, 228, 15)]
	internal interface IVirtualizingLayoutContextOverrides
	{
		// Token: 0x06000690 RID: 1680
		int ItemCountCore();

		// Token: 0x06000691 RID: 1681
		object GetItemAtCore([In] int index);

		// Token: 0x06000692 RID: 1682
		Rect RealizationRectCore();

		// Token: 0x06000693 RID: 1683
		UIElement GetOrCreateElementAtCore([In] int index, [In] ElementRealizationOptions options);

		// Token: 0x06000694 RID: 1684
		void RecycleElementCore([In] UIElement element);

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000695 RID: 1685
		int RecommendedAnchorIndexCore { get; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000696 RID: 1686
		// (set) Token: 0x06000697 RID: 1687
		Point LayoutOriginCore
		{
			get; [param: In]
			set;
		}
	}
}
