using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TeachingTipTemplateSettings))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1663108421u, 57749, 22221, 188, 205, 22, 146, 85, 225, 52, 227)]
	internal interface ITeachingTipTemplateSettingsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TeachingTipTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
