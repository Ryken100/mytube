using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Windows.Foundation.Metadata.Guid(3370374u, 49605, 21951, 162, 13, 169, 244, 81, 35, 99, 239)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemStatics
	{
		DependencyProperty IconProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty CompactPaneLengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
