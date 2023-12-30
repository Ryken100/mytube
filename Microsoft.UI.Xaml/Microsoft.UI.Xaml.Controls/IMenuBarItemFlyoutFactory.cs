using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(MenuBarItemFlyout))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(4170519102u, 60756, 23190, 132, 24, 243, 94, 72, 80, 93, 67)]
	internal interface IMenuBarItemFlyoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MenuBarItemFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
