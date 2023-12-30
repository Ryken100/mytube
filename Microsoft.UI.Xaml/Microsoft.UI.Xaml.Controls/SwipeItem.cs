using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(ISwipeItemFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(ISwipeItemStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	public class SwipeItem : DependencyObject, ISwipeItem
	{
		public extern string Text
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern IconSource IconSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Brush Foreground
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern object CommandParameter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern ICommand Command
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		public extern SwipeBehaviorOnInvoked BehaviorOnInvoked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			[param: In]
			set;
		}

		public extern Brush Background
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public static extern DependencyProperty BackgroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty BehaviorOnInvokedProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty CommandParameterProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty CommandProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ForegroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IconSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TextProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked;
	}
}
