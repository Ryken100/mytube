using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200017F RID: 383
	[ContractVersion(typeof(XamlContract), 131072U)]
	[Guid(1000425103U, 8875, 21003, 141, 23, 156, 187, 62, 238, 149, 12)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[WebHostHidden]
	internal interface IXamlControlsResources3
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600069E RID: 1694
		// (set) Token: 0x0600069F RID: 1695
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		ControlsResourcesVersion ControlsResourcesVersion
		{
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			[param: In]
			set;
		}
	}
}
