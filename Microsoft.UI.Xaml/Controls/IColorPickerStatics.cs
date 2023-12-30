using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000090 RID: 144
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2937985096U, 39134, 22174, 168, 75, 28, 136, 187, 208, 212, 121)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ColorPicker))]
	internal interface IColorPickerStatics
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001C1 RID: 449
		DependencyProperty ColorProperty { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001C2 RID: 450
		DependencyProperty PreviousColorProperty { get; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001C3 RID: 451
		DependencyProperty IsAlphaEnabledProperty { get; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001C4 RID: 452
		DependencyProperty IsColorSpectrumVisibleProperty { get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001C5 RID: 453
		DependencyProperty IsColorPreviewVisibleProperty { get; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001C6 RID: 454
		DependencyProperty IsColorSliderVisibleProperty { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001C7 RID: 455
		DependencyProperty IsAlphaSliderVisibleProperty { get; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001C8 RID: 456
		DependencyProperty IsMoreButtonVisibleProperty { get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001C9 RID: 457
		DependencyProperty IsColorChannelTextInputVisibleProperty { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001CA RID: 458
		DependencyProperty IsAlphaTextInputVisibleProperty { get; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001CB RID: 459
		DependencyProperty IsHexInputVisibleProperty { get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001CC RID: 460
		DependencyProperty MinHueProperty { get; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001CD RID: 461
		DependencyProperty MaxHueProperty { get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001CE RID: 462
		DependencyProperty MinSaturationProperty { get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001CF RID: 463
		DependencyProperty MaxSaturationProperty { get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001D0 RID: 464
		DependencyProperty MinValueProperty { get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001D1 RID: 465
		DependencyProperty MaxValueProperty { get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001D2 RID: 466
		DependencyProperty ColorSpectrumShapeProperty { get; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001D3 RID: 467
		DependencyProperty ColorSpectrumComponentsProperty { get; }
	}
}
