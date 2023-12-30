using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3898880772u, 28084, 23285, 186, 194, 98, 115, 60, 160, 55, 218)]
	[ExclusiveTo(typeof(NavigationViewPaneClosingEventArgs))]
	internal interface INavigationViewPaneClosingEventArgs
	{
		bool Cancel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
