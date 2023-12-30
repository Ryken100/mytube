using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization.NumberFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F1 RID: 241
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(583285351U, 54163, 22185, 128, 26, 45, 234, 145, 135, 125, 230)]
	[ExclusiveTo(typeof(NumberBox))]
	internal interface INumberBox
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000369 RID: 873
		// (set) Token: 0x0600036A RID: 874
		[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
		[MUXPropertyChangedCallback(enable = true)]
		double Minimum
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
			get;
			[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600036B RID: 875
		// (set) Token: 0x0600036C RID: 876
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
		double Maximum
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
			[param: In]
			set;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600036D RID: 877
		// (set) Token: 0x0600036E RID: 878
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
		double Value
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
			get;
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600036F RID: 879
		// (set) Token: 0x06000370 RID: 880
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		double SmallChange
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "1")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000371 RID: 881
		// (set) Token: 0x06000372 RID: 882
		[MUXPropertyDefaultValue(value = "10")]
		[MUXPropertyDefaultValue(value = "10")]
		double LargeChange
		{
			[MUXPropertyDefaultValue(value = "10")]
			get;
			[MUXPropertyDefaultValue(value = "10")]
			[param: In]
			set;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000373 RID: 883
		// (set) Token: 0x06000374 RID: 884
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		string Text
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000375 RID: 885
		// (set) Token: 0x06000376 RID: 886
		object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000377 RID: 887
		// (set) Token: 0x06000378 RID: 888
		DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000379 RID: 889
		// (set) Token: 0x0600037A RID: 890
		string PlaceholderText
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600037B RID: 891
		// (set) Token: 0x0600037C RID: 892
		FlyoutBase SelectionFlyout
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600037D RID: 893
		// (set) Token: 0x0600037E RID: 894
		SolidColorBrush SelectionHighlightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600037F RID: 895
		// (set) Token: 0x06000380 RID: 896
		TextReadingOrder TextReadingOrder
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000381 RID: 897
		// (set) Token: 0x06000382 RID: 898
		bool PreventKeyboardDisplayOnProgrammaticFocus
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000383 RID: 899
		// (set) Token: 0x06000384 RID: 900
		object Description
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000385 RID: 901
		// (set) Token: 0x06000386 RID: 902
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		NumberBoxValidationMode ValidationMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000387 RID: 903
		// (set) Token: 0x06000388 RID: 904
		[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
		NumberBoxSpinButtonPlacementMode SpinButtonPlacementMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
			[param: In]
			set;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000389 RID: 905
		// (set) Token: 0x0600038A RID: 906
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		bool IsWrapEnabled
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600038B RID: 907
		// (set) Token: 0x0600038C RID: 908
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		bool AcceptsExpression
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600038D RID: 909
		// (set) Token: 0x0600038E RID: 910
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
		[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
		INumberFormatter2 NumberFormatter
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
			get;
			[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600038F RID: 911
		// (remove) Token: 0x06000390 RID: 912
		event TypedEventHandler<NumberBox, NumberBoxValueChangedEventArgs> ValueChanged;
	}
}
