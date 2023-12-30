using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2948552186u, 65401, 21802, 163, 161, 72, 226, 239, 23, 21, 42)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(SymbolIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISymbolIconSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		SymbolIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
