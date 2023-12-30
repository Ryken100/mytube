using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000126 RID: 294
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2124296875U, 15417, 22700, 157, 13, 70, 72, 190, 34, 11, 220)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	internal interface IRefreshVisualizerStatics
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060004C7 RID: 1223
		[MUXPropertyType(value = "winrt::IInspectable")]
		DependencyProperty InfoProviderProperty
		{
			[MUXPropertyType(value = "winrt::IInspectable")]
			get;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060004C8 RID: 1224
		DependencyProperty OrientationProperty { get; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060004C9 RID: 1225
		DependencyProperty ContentProperty { get; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060004CA RID: 1226
		DependencyProperty StateProperty { get; }
	}
}
