using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(2332622954u, 25153, 22863, 147, 228, 139, 240, 81, 215, 186, 143)]
	[ExclusiveTo(typeof(SplitButton))]
	[WebHostHidden]
	internal interface ISplitButton
	{
		FlyoutBase Flyout
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		ICommand Command
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		object CommandParameter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> Click;
	}
}
