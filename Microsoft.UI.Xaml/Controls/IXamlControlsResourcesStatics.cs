using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000180 RID: 384
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(2411326363U, 34058, 21029, 150, 207, 167, 32, 54, 4, 51, 66)]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IXamlControlsResourcesStatics
	{
		// Token: 0x060006A0 RID: 1696
		void EnsureRevealLights([In] UIElement element);
	}
}
