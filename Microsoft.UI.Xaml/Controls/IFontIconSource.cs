using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200009F RID: 159
	[ExclusiveTo(typeof(FontIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(3723708164U, 50493, 22300, 137, 15, 59, 94, 48, 93, 220, 105)]
	[WebHostHidden]
	internal interface IFontIconSource
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001FB RID: 507
		// (set) Token: 0x060001FC RID: 508
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		string Glyph
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001FD RID: 509
		// (set) Token: 0x060001FE RID: 510
		[MUXPropertyDefaultValue(value = "20.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "20.0")]
		double FontSize
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "20.0")]
			get;
			[MUXPropertyDefaultValue(value = "20.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001FF RID: 511
		// (set) Token: 0x06000200 RID: 512
		[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
		[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		FontFamily FontFamily
		{
			[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000201 RID: 513
		// (set) Token: 0x06000202 RID: 514
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "{ 400 }")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "{ 400 }")]
		FontWeight FontWeight
		{
			[MUXPropertyDefaultValue(value = "{ 400 }")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "{ 400 }")]
			[param: In]
			set;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000203 RID: 515
		// (set) Token: 0x06000204 RID: 516
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
		[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
		[MUXPropertyChangedCallback(enable = true)]
		FontStyle FontStyle
		{
			[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
			[param: In]
			set;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000205 RID: 517
		// (set) Token: 0x06000206 RID: 518
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsTextScaleFactorEnabled
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000207 RID: 519
		// (set) Token: 0x06000208 RID: 520
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool MirroredWhenRightToLeft
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
