using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(76136288u, 63024, 20748, 152, 220, 177, 35, 34, 38, 14, 31)]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemPresenter
	{
		IconElement Icon
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		NavigationViewItemPresenterTemplateSettings TemplateSettings
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
