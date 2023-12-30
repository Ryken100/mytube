using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C9 RID: 457
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(4025275458U, 35882, 20646, 136, 163, 57, 153, 234, 1, 240, 150)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ColorSpectrum))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IColorSpectrumFactory
	{
		// Token: 0x06000929 RID: 2345
		ColorSpectrum CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
