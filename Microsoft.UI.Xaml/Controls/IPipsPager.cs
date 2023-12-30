using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FF RID: 255
	[Guid(3683250806U, 51672, 23490, 185, 173, 171, 142, 243, 62, 216, 225)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(PipsPager))]
	internal interface IPipsPager
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060003FA RID: 1018
		// (set) Token: 0x060003FB RID: 1019
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		int NumberOfPages
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060003FC RID: 1020
		// (set) Token: 0x060003FD RID: 1021
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int SelectedPageIndex
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060003FE RID: 1022
		// (set) Token: 0x060003FF RID: 1023
		[MUXPropertyDefaultValue(value = "5")]
		[MUXPropertyDefaultValue(value = "5")]
		int MaxVisiblePips
		{
			[MUXPropertyDefaultValue(value = "5")]
			get;
			[MUXPropertyDefaultValue(value = "5")]
			[param: In]
			set;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000400 RID: 1024
		// (set) Token: 0x06000401 RID: 1025
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			[param: In]
			set;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000402 RID: 1026
		// (set) Token: 0x06000403 RID: 1027
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		PipsPagerButtonVisibility PreviousButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			[param: In]
			set;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000404 RID: 1028
		// (set) Token: 0x06000405 RID: 1029
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		PipsPagerButtonVisibility NextButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			[param: In]
			set;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000406 RID: 1030
		// (set) Token: 0x06000407 RID: 1031
		Style PreviousButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000408 RID: 1032
		// (set) Token: 0x06000409 RID: 1033
		Style NextButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600040A RID: 1034
		// (set) Token: 0x0600040B RID: 1035
		Style SelectedPipStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600040C RID: 1036
		// (set) Token: 0x0600040D RID: 1037
		Style NormalPipStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600040E RID: 1038
		// (remove) Token: 0x0600040F RID: 1039
		event TypedEventHandler<PipsPager, PipsPagerSelectedIndexChangedEventArgs> SelectedIndexChanged;

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000410 RID: 1040
		[MUXPropertyNeedsDependencyPropertyField]
		PipsPagerTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
