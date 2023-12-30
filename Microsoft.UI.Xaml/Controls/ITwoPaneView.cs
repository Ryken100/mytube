using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000172 RID: 370
	[WebHostHidden]
	[Guid(2246952325U, 5249, 21623, 187, 18, 42, 24, 163, 43, 131, 78)]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TwoPaneView))]
	internal interface ITwoPaneView
	{
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600064D RID: 1613
		// (set) Token: 0x0600064E RID: 1614
		UIElement Pane1
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600064F RID: 1615
		// (set) Token: 0x06000650 RID: 1616
		UIElement Pane2
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000651 RID: 1617
		// (set) Token: 0x06000652 RID: 1618
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		GridLength Pane1Length
		{
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			get;
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			[param: In]
			set;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000653 RID: 1619
		// (set) Token: 0x06000654 RID: 1620
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		GridLength Pane2Length
		{
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			get;
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			[param: In]
			set;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000655 RID: 1621
		// (set) Token: 0x06000656 RID: 1622
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		TwoPaneViewPriority PanePriority
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			[param: In]
			set;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000657 RID: 1623
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
		[MUXPropertyChangedCallback(enable = false)]
		TwoPaneViewMode Mode
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000658 RID: 1624
		// (set) Token: 0x06000659 RID: 1625
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		TwoPaneViewWideModeConfiguration WideModeConfiguration
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			[param: In]
			set;
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600065A RID: 1626
		// (set) Token: 0x0600065B RID: 1627
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		TwoPaneViewTallModeConfiguration TallModeConfiguration
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			[param: In]
			set;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600065C RID: 1628
		// (set) Token: 0x0600065D RID: 1629
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		double MinWideModeWidth
		{
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			get;
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			[param: In]
			set;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600065E RID: 1630
		// (set) Token: 0x0600065F RID: 1631
		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		double MinTallModeHeight
		{
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			get;
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			[param: In]
			set;
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000660 RID: 1632
		// (remove) Token: 0x06000661 RID: 1633
		event TypedEventHandler<TwoPaneView, object> ModeChanged;
	}
}
