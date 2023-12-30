using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2922882909u, 19535, 20557, 131, 220, 168, 148, 244, 8, 248, 124)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewTemplateSettings
	{
		[MUXPropertyDefaultValue(value = "0.0")]
		double TopPadding
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility OverflowButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		Visibility PaneToggleButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility BackButtonVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility TopPaneVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		Visibility LeftPaneVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		bool SingleSelectionFollowsFocus
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		double PaneToggleButtonWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		double SmallerPaneToggleButtonWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
