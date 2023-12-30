using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014A RID: 330
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Guid(1528824896U, 20428, 24539, 180, 24, 181, 121, 123, 8, 116, 173)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(TeachingTip))]
	internal interface ITeachingTip
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000579 RID: 1401
		// (set) Token: 0x0600057A RID: 1402
		string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600057B RID: 1403
		// (set) Token: 0x0600057C RID: 1404
		string Subtitle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600057D RID: 1405
		// (set) Token: 0x0600057E RID: 1406
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		bool IsOpen
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600057F RID: 1407
		// (set) Token: 0x06000580 RID: 1408
		FrameworkElement Target
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000581 RID: 1409
		// (set) Token: 0x06000582 RID: 1410
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
		TeachingTipTailVisibility TailVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
			[param: In]
			set;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000583 RID: 1411
		// (set) Token: 0x06000584 RID: 1412
		object ActionButtonContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000585 RID: 1413
		// (set) Token: 0x06000586 RID: 1414
		Style ActionButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000587 RID: 1415
		// (set) Token: 0x06000588 RID: 1416
		ICommand ActionButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000589 RID: 1417
		// (set) Token: 0x0600058A RID: 1418
		object ActionButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600058B RID: 1419
		// (set) Token: 0x0600058C RID: 1420
		object CloseButtonContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600058D RID: 1421
		// (set) Token: 0x0600058E RID: 1422
		Style CloseButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600058F RID: 1423
		// (set) Token: 0x06000590 RID: 1424
		ICommand CloseButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000591 RID: 1425
		// (set) Token: 0x06000592 RID: 1426
		object CloseButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000593 RID: 1427
		// (set) Token: 0x06000594 RID: 1428
		Thickness PlacementMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000595 RID: 1429
		// (set) Token: 0x06000596 RID: 1430
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool ShouldConstrainToRootBounds
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000597 RID: 1431
		// (set) Token: 0x06000598 RID: 1432
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		bool IsLightDismissEnabled
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000599 RID: 1433
		// (set) Token: 0x0600059A RID: 1434
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
		TeachingTipPlacementMode PreferredPlacement
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600059B RID: 1435
		// (set) Token: 0x0600059C RID: 1436
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
		TeachingTipHeroContentPlacementMode HeroContentPlacement
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600059D RID: 1437
		// (set) Token: 0x0600059E RID: 1438
		UIElement HeroContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600059F RID: 1439
		// (set) Token: 0x060005A0 RID: 1440
		IconSource IconSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060005A1 RID: 1441
		TeachingTipTemplateSettings TemplateSettings { get; }

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060005A2 RID: 1442
		// (remove) Token: 0x060005A3 RID: 1443
		event TypedEventHandler<TeachingTip, object> ActionButtonClick;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060005A4 RID: 1444
		// (remove) Token: 0x060005A5 RID: 1445
		event TypedEventHandler<TeachingTip, object> CloseButtonClick;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060005A6 RID: 1446
		// (remove) Token: 0x060005A7 RID: 1447
		event TypedEventHandler<TeachingTip, TeachingTipClosingEventArgs> Closing;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060005A8 RID: 1448
		// (remove) Token: 0x060005A9 RID: 1449
		event TypedEventHandler<TeachingTip, TeachingTipClosedEventArgs> Closed;
	}
}
