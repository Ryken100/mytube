using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3130520375u, 36638, 20801, 181, 63, 231, 122, 139, 163, 235, 189)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBar))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IMenuBar
	{
		IList<MenuBarItem> Items
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
