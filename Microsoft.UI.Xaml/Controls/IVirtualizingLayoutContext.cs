using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000179 RID: 377
	[ExclusiveTo(typeof(VirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(674317300U, 14102, 20481, 144, 173, 16, 121, 242, 13, 244, 186)]
	internal interface IVirtualizingLayoutContext
	{
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000686 RID: 1670
		int ItemCount { get; }

		// Token: 0x06000687 RID: 1671
		object GetItemAt([In] int index);

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000688 RID: 1672
		Rect RealizationRect { get; }

		// Token: 0x06000689 RID: 1673
		[Overload("GetOrCreateElementAt")]
		UIElement GetOrCreateElementAt([In] int index);

		// Token: 0x0600068A RID: 1674
		[Overload("GetOrCreateElementAt2")]
		UIElement GetOrCreateElementAt([In] int index, [In] ElementRealizationOptions options);

		// Token: 0x0600068B RID: 1675
		void RecycleElement([In] UIElement element);

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600068C RID: 1676
		int RecommendedAnchorIndex { get; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600068D RID: 1677
		// (set) Token: 0x0600068E RID: 1678
		Point LayoutOrigin
		{
			get; [param: In]
			set;
		}
	}
}
