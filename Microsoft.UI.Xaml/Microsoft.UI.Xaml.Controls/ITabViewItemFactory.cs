using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TabViewItem))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3058443299u, 32342, 23873, 138, 132, 30, 226, 143, 152, 38, 164)]
	internal interface ITabViewItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
