using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2995454304u, 556, 22844, 171, 154, 123, 61, 237, 44, 7, 84)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[WebHostHidden]
	internal interface INavigationViewItemPresenterFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItemPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
