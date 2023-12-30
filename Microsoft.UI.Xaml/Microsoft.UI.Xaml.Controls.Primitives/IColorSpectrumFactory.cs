using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(4025275458u, 35882, 20646, 136, 163, 57, 153, 234, 1, 240, 150)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ColorSpectrum))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IColorSpectrumFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorSpectrum CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
