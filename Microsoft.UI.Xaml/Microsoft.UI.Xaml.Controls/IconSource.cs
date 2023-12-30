using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Bindable]
	[Composable(typeof(IIconSourceFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IIconSourceStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	public class IconSource : DependencyObject, IIconSource
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Brush Foreground
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		public static extern DependencyProperty ForegroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IconElement CreateIconElement();
	}
}
