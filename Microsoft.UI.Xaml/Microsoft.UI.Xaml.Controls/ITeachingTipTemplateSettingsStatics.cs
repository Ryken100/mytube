using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1653988040u, 28930, 22018, 184, 249, 229, 0, 229, 152, 68, 143)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TeachingTipTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITeachingTipTemplateSettingsStatics
	{
		DependencyProperty TopRightHighlightMarginProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty TopLeftHighlightMarginProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty IconElementProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
