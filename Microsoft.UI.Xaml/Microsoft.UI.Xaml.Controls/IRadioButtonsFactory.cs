using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(754540283u, 42914, 23941, 142, 173, 234, 34, 43, 170, 60, 85)]
	[ExclusiveTo(typeof(RadioButtons))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IRadioButtonsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RadioButtons CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
