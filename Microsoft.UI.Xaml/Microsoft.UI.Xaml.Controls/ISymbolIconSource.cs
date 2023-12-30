using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(528521428u, 62442, 21344, 176, 170, 128, 101, 187, 114, 38, 174)]
	[ExclusiveTo(typeof(SymbolIconSource))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ISymbolIconSource
	{
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		Symbol Symbol
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[param: In]
			set;
		}
	}
}
