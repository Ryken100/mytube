using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000112 RID: 274
	[ContractVersion(typeof(XamlContract), 131072U)]
	[WebHostHidden]
	[Guid(122615017U, 9907, 22679, 172, 111, 16, 207, 9, 71, 170, 218)]
	[ExclusiveTo(typeof(RadioMenuFlyoutItem))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IRadioMenuFlyoutItemStatics2
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000469 RID: 1129
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
		DependencyProperty AreCheckStatesEnabledProperty
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
			get;
		}

		// Token: 0x0600046A RID: 1130
		void SetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object, [In] bool value);

		// Token: 0x0600046B RID: 1131
		bool GetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object);
	}
}
