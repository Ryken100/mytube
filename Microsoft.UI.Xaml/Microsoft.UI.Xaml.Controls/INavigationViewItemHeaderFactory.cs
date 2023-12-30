using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewItemHeader))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1783908301u, 10520, 24547, 137, 155, 147, 214, 150, 18, 133, 230)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemHeaderFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItemHeader CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
