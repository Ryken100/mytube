using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(889154708u, 25701, 24382, 176, 165, 79, 30, 234, 72, 231, 67)]
	[WebHostHidden]
	internal interface INavigationViewTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
