using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1925402850u, 2592, 23451, 172, 84, 99, 59, 151, 215, byte.MaxValue, 222)]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(ColorPicker))]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IColorPickerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorPicker CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
