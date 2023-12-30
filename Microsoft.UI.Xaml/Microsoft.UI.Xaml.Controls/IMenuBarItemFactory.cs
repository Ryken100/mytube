using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(MenuBarItem))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2278564210u, 33739, 21593, 148, 15, 23, 63, 117, 1, 179, 0)]
	internal interface IMenuBarItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MenuBarItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
