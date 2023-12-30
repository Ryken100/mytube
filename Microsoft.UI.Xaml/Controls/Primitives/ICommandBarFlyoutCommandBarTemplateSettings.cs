using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D3 RID: 467
	[MUXPropertyNeedsDependencyPropertyField]
	[Guid(1396491722U, 56567, 24477, 164, 96, 147, 74, 136, 58, 205, 193)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBarTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ICommandBarFlyoutCommandBarTemplateSettings
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000946 RID: 2374
		double OpenAnimationStartPosition { get; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000947 RID: 2375
		double OpenAnimationEndPosition { get; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000948 RID: 2376
		double CloseAnimationEndPosition { get; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000949 RID: 2377
		double CurrentWidth { get; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600094A RID: 2378
		double ExpandedWidth { get; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600094B RID: 2379
		double WidthExpansionDelta { get; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600094C RID: 2380
		double WidthExpansionAnimationStartPosition { get; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600094D RID: 2381
		double WidthExpansionAnimationEndPosition { get; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600094E RID: 2382
		double WidthExpansionMoreButtonAnimationStartPosition { get; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600094F RID: 2383
		double WidthExpansionMoreButtonAnimationEndPosition { get; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000950 RID: 2384
		double ExpandUpOverflowVerticalPosition { get; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000951 RID: 2385
		double ExpandDownOverflowVerticalPosition { get; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000952 RID: 2386
		double ExpandUpAnimationStartPosition { get; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000953 RID: 2387
		double ExpandUpAnimationEndPosition { get; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000954 RID: 2388
		double ExpandUpAnimationHoldPosition { get; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000955 RID: 2389
		double ExpandDownAnimationStartPosition { get; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000956 RID: 2390
		double ExpandDownAnimationEndPosition { get; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000957 RID: 2391
		double ExpandDownAnimationHoldPosition { get; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000958 RID: 2392
		Rect ContentClipRect { get; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000959 RID: 2393
		Rect OverflowContentClipRect { get; }
	}
}
