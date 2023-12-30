using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2708286738u, 56236, 23776, 174, 245, 9, 23, 26, 77, 53, 113)]
	[ExclusiveTo(typeof(NonVirtualizingLayout))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface INonVirtualizingLayoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NonVirtualizingLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
