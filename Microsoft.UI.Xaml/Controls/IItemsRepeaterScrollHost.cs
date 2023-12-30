using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BA RID: 186
	[Guid(2728085381U, 33296, 24174, 164, 12, 54, 168, 43, 120, 123, 79)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ItemsRepeaterScrollHost))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IItemsRepeaterScrollHost
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000272 RID: 626
		// (set) Token: 0x06000273 RID: 627
		ScrollViewer ScrollViewer
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000274 RID: 628
		UIElement CurrentAnchor { get; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000275 RID: 629
		// (set) Token: 0x06000276 RID: 630
		double HorizontalAnchorRatio
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000277 RID: 631
		// (set) Token: 0x06000278 RID: 632
		double VerticalAnchorRatio
		{
			get; [param: In]
			set;
		}
	}
}
