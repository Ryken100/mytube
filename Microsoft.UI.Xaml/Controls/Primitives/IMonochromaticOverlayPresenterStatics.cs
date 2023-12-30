using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DD RID: 477
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(4198045140U, 52070, 21037, 131, 226, 54, 233, 136, 255, 160, 164)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MonochromaticOverlayPresenter))]
	internal interface IMonochromaticOverlayPresenterStatics
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000978 RID: 2424
		DependencyProperty SourceElementProperty { get; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000979 RID: 2425
		DependencyProperty ReplacementColorProperty { get; }
	}
}
