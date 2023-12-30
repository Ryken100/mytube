using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2514135788u, 57892, 22188, 151, 73, 78, 221, 172, 12, 48, 67)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(BreadcrumbBar))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IBreadcrumbBarStatics
	{
		DependencyProperty ItemsSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ItemTemplateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
