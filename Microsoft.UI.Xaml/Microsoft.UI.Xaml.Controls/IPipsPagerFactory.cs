using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(PipsPager))]
	[Windows.Foundation.Metadata.Guid(34022093u, 33082, 20837, 168, 153, 61, 249, 173, 205, 128, 94)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IPipsPagerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PipsPager CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
