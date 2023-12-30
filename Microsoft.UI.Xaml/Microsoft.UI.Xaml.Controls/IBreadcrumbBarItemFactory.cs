using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(BreadcrumbBarItem))]
	[Windows.Foundation.Metadata.Guid(409746387u, 28680, 21828, 141, 58, 101, 175, 143, 233, 254, 105)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IBreadcrumbBarItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		BreadcrumbBarItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
