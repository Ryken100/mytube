using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200023F RID: 575
	[Guid(828522908U, 51900, 23374, 156, 100, 120, 99, 84, 20, 114, 87)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAcrylicBrushStatics
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000C60 RID: 3168
		DependencyProperty BackgroundSourceProperty { get; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06000C61 RID: 3169
		DependencyProperty TintColorProperty { get; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06000C62 RID: 3170
		DependencyProperty TintOpacityProperty { get; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06000C63 RID: 3171
		DependencyProperty TintTransitionDurationProperty { get; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000C64 RID: 3172
		DependencyProperty AlwaysUseFallbackProperty { get; }
	}
}
