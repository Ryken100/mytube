using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(TabViewItemTemplateSettings))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1084492474u, 40642, 23381, 182, 228, 117, 86, 165, 160, 96, 24)]
	internal interface ITabViewItemTemplateSettingsStatics
	{
		DependencyProperty IconElementProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
