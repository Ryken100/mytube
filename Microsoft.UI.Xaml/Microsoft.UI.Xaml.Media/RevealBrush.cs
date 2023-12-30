using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[WebHostHidden]
	[Static(typeof(IRevealBrushStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(IRevealBrushProtectedFactory), CompositionType.Protected, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class RevealBrush : XamlCompositionBrushBase, IRevealBrush
	{
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		public extern ApplicationTheme TargetTheme
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		public extern Color Color
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			[param: In]
			set;
		}

		public extern bool AlwaysUseFallback
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public static extern DependencyProperty AlwaysUseFallbackProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ColorProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
		public static extern DependencyProperty StateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
			[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
			get;
		}

		public static extern DependencyProperty TargetThemeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetState([In] UIElement element, [In] RevealBrushState value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern RevealBrushState GetState([In] UIElement element);
	}
}
