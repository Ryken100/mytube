using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewItemPresenterTemplateSettings))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(435098408u, 21191, 21987, 177, 187, 146, 63, 47, 57, 189, 110)]
	internal interface INavigationViewItemPresenterTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItemPresenterTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
