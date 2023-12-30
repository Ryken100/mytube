using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(InfoBarTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(693206447u, 51043, 22222, 141, 84, 238, 252, 175, 127, 46, 1)]
	internal interface IInfoBarTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		InfoBarTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
