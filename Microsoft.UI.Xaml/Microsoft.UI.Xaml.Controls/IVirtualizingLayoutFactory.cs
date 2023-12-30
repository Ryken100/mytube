using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3351324897u, 24055, 21317, 181, 205, 67, 175, 223, 169, 72, 180)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(VirtualizingLayout))]
	[WebHostHidden]
	internal interface IVirtualizingLayoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		VirtualizingLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
