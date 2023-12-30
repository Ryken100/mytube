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
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ICommandBarFlyoutCommandBarAutomationPropertiesStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public static class CommandBarFlyoutCommandBarAutomationProperties
	{
		[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
		[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
		public static extern DependencyProperty ControlTypeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
			[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern AutomationControlType GetControlType([In] UIElement element);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetControlType([In] UIElement element, [In] AutomationControlType value);
	}
}
