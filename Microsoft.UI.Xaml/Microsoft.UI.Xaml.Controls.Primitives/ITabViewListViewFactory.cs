using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2315800541u, 34544, 20974, 152, 223, 95, 189, 11, 86, 105, 190)]
	[ExclusiveTo(typeof(TabViewListView))]
	internal interface ITabViewListViewFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabViewListView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
