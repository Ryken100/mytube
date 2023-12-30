using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3130465533u, 20535, 23435, 169, 94, 101, 44, 101, 236, 170, 191)]
	[ExclusiveTo(typeof(NavigationViewItemPresenterTemplateSettings))]
	internal interface INavigationViewItemPresenterTemplateSettingsStatics
	{
		DependencyProperty IconWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty SmallerIconWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
