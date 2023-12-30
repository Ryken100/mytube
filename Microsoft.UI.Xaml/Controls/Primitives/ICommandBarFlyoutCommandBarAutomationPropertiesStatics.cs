using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D1 RID: 465
	[WebHostHidden]
	[Guid(2698630495U, 2317, 24357, 137, 83, 15, 209, 230, 95, 155, 90)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBarAutomationProperties))]
	internal interface ICommandBarFlyoutCommandBarAutomationPropertiesStatics
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000942 RID: 2370
		[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
		DependencyProperty ControlTypeProperty
		{
			[MUXPropertyDefaultValue(value = "winrt::AutomationControlType::Custom")]
			[MUXPropertyChangedCallbackMethodName(value = "OnControlTypePropertyChanged")]
			get;
		}

		// Token: 0x06000943 RID: 2371
		AutomationControlType GetControlType([In] UIElement element);

		// Token: 0x06000944 RID: 2372
		void SetControlType([In] UIElement element, [In] AutomationControlType value);
	}
}
