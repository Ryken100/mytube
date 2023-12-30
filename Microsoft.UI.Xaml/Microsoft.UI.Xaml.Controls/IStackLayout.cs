using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(1811412507u, 3311, 23954, 168, 40, 147, 239, 189, 109, 244, 193)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(StackLayout))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IStackLayout
	{
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		Orientation Orientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double Spacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}
	}
}
