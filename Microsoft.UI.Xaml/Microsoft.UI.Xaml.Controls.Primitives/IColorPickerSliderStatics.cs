using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2542973335u, 51300, 23027, 159, 160, 226, 28, 127, 212, 107, 121)]
	[ExclusiveTo(typeof(ColorPickerSlider))]
	internal interface IColorPickerSliderStatics
	{
		DependencyProperty ColorChannelProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
