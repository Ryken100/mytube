using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(BitmapIconSource))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2101890068u, 62966, 24121, 180, 228, 182, 16, 141, 46, 224, 149)]
	internal interface IBitmapIconSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		BitmapIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
