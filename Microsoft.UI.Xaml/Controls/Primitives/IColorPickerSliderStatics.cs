using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C7 RID: 455
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2542973335U, 51300, 23027, 159, 160, 226, 28, 127, 212, 107, 121)]
	[ExclusiveTo(typeof(ColorPickerSlider))]
	internal interface IColorPickerSliderStatics
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000912 RID: 2322
		DependencyProperty ColorChannelProperty { get; }
	}
}
