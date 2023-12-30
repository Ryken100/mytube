using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(ToggleSplitButton))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1544496251u, 48384, 21769, 136, 168, 176, 144, 7, 174, 34, 176)]
	internal interface IToggleSplitButton
	{
		bool IsChecked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;
	}
}
