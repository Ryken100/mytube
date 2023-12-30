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
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(SwipeItem))]
	[Windows.Foundation.Metadata.Guid(18158561u, 6876, 23145, 167, 79, 98, 63, 204, 24, 165, 28)]
	internal interface ISwipeItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		SwipeItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
