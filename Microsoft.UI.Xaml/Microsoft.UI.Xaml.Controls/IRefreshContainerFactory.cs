using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RefreshContainer))]
	[Windows.Foundation.Metadata.Guid(1596100513u, 11938, 21173, 183, 138, 12, 19, 63, 134, 240, 32)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRefreshContainerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RefreshContainer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
