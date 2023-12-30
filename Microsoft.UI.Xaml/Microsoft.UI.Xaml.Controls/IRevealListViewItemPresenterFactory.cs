using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3878733115u, 36756, 21939, 139, 193, 152, 247, 124, 87, 102, 189)]
	[ExclusiveTo(typeof(RevealListViewItemPresenter))]
	internal interface IRevealListViewItemPresenterFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RevealListViewItemPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
