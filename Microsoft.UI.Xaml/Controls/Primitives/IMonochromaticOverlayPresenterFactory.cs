using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DC RID: 476
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(MonochromaticOverlayPresenter))]
	[WebHostHidden]
	[Guid(1234666619U, 46424, 23692, 130, 152, 190, 21, 50, 232, 152, 236)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IMonochromaticOverlayPresenterFactory
	{
		// Token: 0x06000977 RID: 2423
		MonochromaticOverlayPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
