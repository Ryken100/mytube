using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F3 RID: 243
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2086184993U, 17725, 21869, 162, 37, 87, 80, 81, 63, 113, 121)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NumberBox))]
	internal interface INumberBoxStatics
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000392 RID: 914
		DependencyProperty MinimumProperty { get; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000393 RID: 915
		DependencyProperty MaximumProperty { get; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000394 RID: 916
		DependencyProperty ValueProperty { get; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000395 RID: 917
		DependencyProperty SmallChangeProperty { get; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000396 RID: 918
		DependencyProperty LargeChangeProperty { get; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000397 RID: 919
		DependencyProperty TextProperty { get; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000398 RID: 920
		[MUXPropertyChangedCallback(enable = true)]
		DependencyProperty HeaderProperty
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000399 RID: 921
		[MUXPropertyChangedCallback(enable = true)]
		DependencyProperty HeaderTemplateProperty
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600039A RID: 922
		DependencyProperty PlaceholderTextProperty { get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600039B RID: 923
		DependencyProperty SelectionFlyoutProperty { get; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600039C RID: 924
		DependencyProperty SelectionHighlightColorProperty { get; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600039D RID: 925
		DependencyProperty TextReadingOrderProperty { get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600039E RID: 926
		DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600039F RID: 927
		DependencyProperty DescriptionProperty { get; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060003A0 RID: 928
		DependencyProperty ValidationModeProperty { get; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060003A1 RID: 929
		DependencyProperty SpinButtonPlacementModeProperty { get; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060003A2 RID: 930
		DependencyProperty IsWrapEnabledProperty { get; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060003A3 RID: 931
		DependencyProperty AcceptsExpressionProperty { get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060003A4 RID: 932
		DependencyProperty NumberFormatterProperty { get; }
	}
}
