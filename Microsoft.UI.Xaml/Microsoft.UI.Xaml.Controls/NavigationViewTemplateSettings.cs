using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Composable(typeof(INavigationViewTemplateSettingsFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[Static(typeof(INavigationViewTemplateSettingsStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class NavigationViewTemplateSettings : DependencyObject, INavigationViewTemplateSettings
	{
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility BackButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		public extern Visibility LeftPaneVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility OverflowButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		public extern Visibility PaneToggleButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		public extern double PaneToggleButtonWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool SingleSelectionFollowsFocus
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern double SmallerPaneToggleButtonWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double TopPadding
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility TopPaneVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		public static extern DependencyProperty BackButtonVisibilityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty LeftPaneVisibilityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty OverflowButtonVisibilityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneToggleButtonVisibilityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneToggleButtonWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SingleSelectionFollowsFocusProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SmallerPaneToggleButtonWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TopPaddingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TopPaneVisibilityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
