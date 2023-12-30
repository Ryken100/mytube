using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1652745526u, 7420, 23846, 159, 109, 143, 51, 77, 175, 153, 126)]
	[ExclusiveTo(typeof(MenuBarItem))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface IMenuBarItemStatics
	{
		DependencyProperty TitleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ItemsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
