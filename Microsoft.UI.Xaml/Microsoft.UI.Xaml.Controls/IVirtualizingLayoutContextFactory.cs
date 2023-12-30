using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(VirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1064897383u, 65019, 20570, 139, 133, 98, 16, 80, 109, 243, 17)]
	internal interface IVirtualizingLayoutContextFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		VirtualizingLayoutContext CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
