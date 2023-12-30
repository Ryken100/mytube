using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3669671968u, 6300, 23487, 164, 220, 151, 218, 17, 153, 245, 119)]
	internal interface INonVirtualizingLayoutContextFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NonVirtualizingLayoutContext CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
