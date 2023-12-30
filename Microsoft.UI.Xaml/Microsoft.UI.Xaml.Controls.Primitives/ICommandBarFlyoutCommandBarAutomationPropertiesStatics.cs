using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2698630495u, 2317, 24357, 137, 83, 15, 209, 230, 95, 155, 90)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBarAutomationProperties))]
	internal interface ICommandBarFlyoutCommandBarAutomationPropertiesStatics
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
		DependencyProperty ControlTypeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
			[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		AutomationControlType GetControlType([In] UIElement element);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetControlType([In] UIElement element, [In] AutomationControlType value);
	}
}
