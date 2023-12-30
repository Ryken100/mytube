using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(BreadcrumbBar))]
	[Windows.Foundation.Metadata.Guid(3585517273u, 12616, 23740, 166, 174, 15, 68, 205, 228, 25, 82)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IBreadcrumbBarFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		BreadcrumbBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
