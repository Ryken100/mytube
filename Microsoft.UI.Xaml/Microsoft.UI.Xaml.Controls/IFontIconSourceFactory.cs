using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(FontIconSource))]
	[Windows.Foundation.Metadata.Guid(3141594862u, 25809, 20787, 177, 214, 174, 19, 194, 27, 102, 120)]
	internal interface IFontIconSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		FontIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
