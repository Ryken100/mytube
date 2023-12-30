using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200023C RID: 572
	[Guid(646323329U, 29428, 20581, 177, 68, 233, 236, 127, 206, 134, 169)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[WebHostHidden]
	internal interface IAcrylicBrush
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000C53 RID: 3155
		// (set) Token: 0x06000C54 RID: 3156
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		AcrylicBackgroundSource BackgroundSource
		{
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			[param: In]
			set;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000C55 RID: 3157
		// (set) Token: 0x06000C56 RID: 3158
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		Color TintColor
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			get;
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			[param: In]
			set;
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000C57 RID: 3159
		// (set) Token: 0x06000C58 RID: 3160
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		double TintOpacity
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[param: In]
			set;
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000C59 RID: 3161
		// (set) Token: 0x06000C5A RID: 3162
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		TimeSpan TintTransitionDuration
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			get;
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			[param: In]
			set;
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000C5B RID: 3163
		// (set) Token: 0x06000C5C RID: 3164
		bool AlwaysUseFallback
		{
			get; [param: In]
			set;
		}
	}
}
