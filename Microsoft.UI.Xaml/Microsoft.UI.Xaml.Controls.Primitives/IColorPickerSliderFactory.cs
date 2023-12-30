using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(ColorPickerSlider))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(3502972686u, 1905, 23677, 186, 20, 170, 67, 17, 121, 178, 172)]
	internal interface IColorPickerSliderFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorPickerSlider CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
