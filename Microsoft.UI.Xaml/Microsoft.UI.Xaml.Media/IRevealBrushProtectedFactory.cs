using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Windows.Foundation.Metadata.Guid(1185501019u, 35517, 21873, 176, 73, 127, 118, 227, 249, 103, 201)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(RevealBrush))]
	[WebHostHidden]
	internal interface IRevealBrushProtectedFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RevealBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
