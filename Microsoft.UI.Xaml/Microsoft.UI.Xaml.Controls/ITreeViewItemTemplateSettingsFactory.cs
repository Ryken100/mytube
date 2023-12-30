using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(488269539u, 62829, 23935, 148, 44, 243, 168, 127, 92, 85, 46)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewItemTemplateSettings))]
	internal interface ITreeViewItemTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewItemTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
