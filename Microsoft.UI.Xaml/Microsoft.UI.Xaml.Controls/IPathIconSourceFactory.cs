using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(PathIconSource))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(2683298590u, 23222, 21396, 166, 239, 103, 47, 23, 77, 51, 59)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IPathIconSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PathIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
