using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[Windows.Foundation.Metadata.Guid(4037404391u, 63014, 21552, 142, 242, 222, 117, 174, 114, 144, 15)]
	internal interface INavigationViewItemPresenterStatics
	{
		DependencyProperty IconProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty TemplateSettingsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
