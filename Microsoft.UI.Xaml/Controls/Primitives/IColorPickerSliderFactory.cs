using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C6 RID: 454
	[ExclusiveTo(typeof(ColorPickerSlider))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3502972686U, 1905, 23677, 186, 20, 170, 67, 17, 121, 178, 172)]
	internal interface IColorPickerSliderFactory
	{
		// Token: 0x06000911 RID: 2321
		ColorPickerSlider CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
