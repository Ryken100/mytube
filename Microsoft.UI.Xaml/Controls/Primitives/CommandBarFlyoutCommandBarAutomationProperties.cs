using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BD RID: 445
	[WebHostHidden]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Static(typeof(ICommandBarFlyoutCommandBarAutomationPropertiesStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public static class CommandBarFlyoutCommandBarAutomationProperties
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060008E3 RID: 2275
		[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
		[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
		public static extern DependencyProperty ControlTypeProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
			[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
			get;
		}

		// Token: 0x060008E4 RID: 2276
		public static extern AutomationControlType GetControlType([In] UIElement element);

		// Token: 0x060008E5 RID: 2277
		public static extern void SetControlType([In] UIElement element, [In] AutomationControlType value);
	}
}
