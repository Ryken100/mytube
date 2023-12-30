using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[Windows.Foundation.Metadata.Guid(2149004115u, 24861, 23042, 136, 100, 26, 170, 39, 157, byte.MaxValue, 28)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IAcrylicBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		AcrylicBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
