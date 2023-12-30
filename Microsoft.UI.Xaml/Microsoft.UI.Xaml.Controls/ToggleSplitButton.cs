using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(IToggleSplitButtonStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IToggleSplitButtonFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	public class ToggleSplitButton : SplitButton, IToggleSplitButton
	{
		public extern bool IsChecked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public static extern DependencyProperty IsCheckedProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;
	}
}
