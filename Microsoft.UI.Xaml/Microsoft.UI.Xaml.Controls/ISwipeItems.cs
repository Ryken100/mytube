using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(SwipeItems))]
	[Windows.Foundation.Metadata.Guid(1087570475u, 51243, 21861, 164, 228, 173, 157, 122, 102, 177, 169)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeItems
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyChangedCallback(enable = true)]
		SwipeMode Mode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			[param: In]
			set;
		}
	}
}
