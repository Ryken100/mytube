using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Composable(typeof(ISymbolIconSourceFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ISymbolIconSourceStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class SymbolIconSource : IconSource, ISymbolIconSource
	{
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		public extern Symbol Symbol
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		public static extern DependencyProperty SymbolProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
