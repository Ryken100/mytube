using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008E RID: 142
	[ExclusiveTo(typeof(ColorPicker))]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2926752331U, 63807, 23065, 140, 228, 161, 139, 115, 195, 53, 109)]
	internal interface IColorPicker
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000198 RID: 408
		// (set) Token: 0x06000199 RID: 409
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		Color Color
		{
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			get;
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			[param: In]
			set;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600019A RID: 410
		// (set) Token: 0x0600019B RID: 411
		IReference<Color> PreviousColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600019C RID: 412
		// (set) Token: 0x0600019D RID: 413
		bool IsAlphaEnabled
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorSpectrumVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001A0 RID: 416
		// (set) Token: 0x060001A1 RID: 417
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorPreviewVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorSliderVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsAlphaSliderVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001A6 RID: 422
		// (set) Token: 0x060001A7 RID: 423
		bool IsMoreButtonVisible
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorChannelTextInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001AB RID: 427
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsAlphaTextInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001AC RID: 428
		// (set) Token: 0x060001AD RID: 429
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsHexInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001AE RID: 430
		// (set) Token: 0x060001AF RID: 431
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinHue
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001B0 RID: 432
		// (set) Token: 0x060001B1 RID: 433
		[MUXPropertyDefaultValue(value = "359")]
		[MUXPropertyDefaultValue(value = "359")]
		int MaxHue
		{
			[MUXPropertyDefaultValue(value = "359")]
			get;
			[MUXPropertyDefaultValue(value = "359")]
			[param: In]
			set;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001B2 RID: 434
		// (set) Token: 0x060001B3 RID: 435
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinSaturation
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001B4 RID: 436
		// (set) Token: 0x060001B5 RID: 437
		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		int MaxSaturation
		{
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001B6 RID: 438
		// (set) Token: 0x060001B7 RID: 439
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinValue
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001B8 RID: 440
		// (set) Token: 0x060001B9 RID: 441
		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		int MaxValue
		{
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001BA RID: 442
		// (set) Token: 0x060001BB RID: 443
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		ColorSpectrumShape ColorSpectrumShape
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			[param: In]
			set;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001BC RID: 444
		// (set) Token: 0x060001BD RID: 445
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		ColorSpectrumComponents ColorSpectrumComponents
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001BE RID: 446
		// (remove) Token: 0x060001BF RID: 447
		event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorChanged;
	}
}
