using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Static(typeof(IStackLayoutStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IStackLayoutFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class StackLayout : VirtualizingLayout, IStackLayout
	{
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double Spacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		public extern Orientation Orientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			[param: In]
			set;
		}

		public static extern DependencyProperty OrientationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SpacingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
