using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(TabViewItemTemplateSettings))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(3416515687u, 19608, 22661, 186, 36, 111, 166, 153, 204, 142, 221)]
	internal interface ITabViewItemTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabViewItemTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
