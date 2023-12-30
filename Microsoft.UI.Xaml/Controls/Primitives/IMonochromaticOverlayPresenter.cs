using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DB RID: 475
	[WebHostHidden]
	[ExclusiveTo(typeof(MonochromaticOverlayPresenter))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1304359977U, 21425, 20762, 153, 136, 112, 187, 205, 46, 225, 34)]
	internal interface IMonochromaticOverlayPresenter
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000973 RID: 2419
		// (set) Token: 0x06000974 RID: 2420
		UIElement SourceElement
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000975 RID: 2421
		// (set) Token: 0x06000976 RID: 2422
		Color ReplacementColor
		{
			get; [param: In]
			set;
		}
	}
}
