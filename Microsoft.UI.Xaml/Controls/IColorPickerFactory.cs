using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008F RID: 143
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1925402850U, 2592, 23451, 172, 84, 99, 59, 151, 215, 255, 222)]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(ColorPicker))]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IColorPickerFactory
	{
		// Token: 0x060001C0 RID: 448
		ColorPicker CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
