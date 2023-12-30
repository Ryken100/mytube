using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200023D RID: 573
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(603641200U, 17389, 23155, 157, 231, 163, 3, 85, 61, 84, 20)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[WebHostHidden]
	internal interface IAcrylicBrush2
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000C5D RID: 3165
		// (set) Token: 0x06000C5E RID: 3166
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		IReference<double> TintLuminosityOpacity
		{
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			[param: In]
			set;
		}
	}
}
