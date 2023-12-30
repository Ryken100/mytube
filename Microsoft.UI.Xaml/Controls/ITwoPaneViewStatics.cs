using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000174 RID: 372
	[Guid(846562203U, 22978, 21507, 166, 183, 139, 33, 236, 214, 171, 163)]
	[ExclusiveTo(typeof(TwoPaneView))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface ITwoPaneViewStatics
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000663 RID: 1635
		DependencyProperty Pane1Property { get; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000664 RID: 1636
		DependencyProperty Pane2Property { get; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000665 RID: 1637
		DependencyProperty Pane1LengthProperty { get; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000666 RID: 1638
		DependencyProperty Pane2LengthProperty { get; }

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000667 RID: 1639
		DependencyProperty PanePriorityProperty { get; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000668 RID: 1640
		DependencyProperty ModeProperty { get; }

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000669 RID: 1641
		DependencyProperty WideModeConfigurationProperty { get; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600066A RID: 1642
		DependencyProperty TallModeConfigurationProperty { get; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600066B RID: 1643
		DependencyProperty MinWideModeWidthProperty { get; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600066C RID: 1644
		DependencyProperty MinTallModeHeightProperty { get; }
	}
}
