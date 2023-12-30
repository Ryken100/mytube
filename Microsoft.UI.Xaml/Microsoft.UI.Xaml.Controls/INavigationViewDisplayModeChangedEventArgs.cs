using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1490874858u, 40534, 21036, 179, 248, 52, 189, 85, 236, 172, 164)]
	[ExclusiveTo(typeof(NavigationViewDisplayModeChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface INavigationViewDisplayModeChangedEventArgs
	{
		NavigationViewDisplayMode DisplayMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
