using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBarTemplateSettings))]
	[Windows.Foundation.Metadata.Guid(3448767095u, 57722, 21193, 128, 148, 15, 180, 245, 204, 25, 184)]
	internal interface IInfoBarTemplateSettingsStatics
	{
		DependencyProperty IconElementProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
