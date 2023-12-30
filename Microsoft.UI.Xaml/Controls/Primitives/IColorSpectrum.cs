using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C8 RID: 456
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ColorSpectrum))]
	[Guid(1966102806U, 34861, 22119, 191, 208, 10, 247, 45, 80, 45, 114)]
	internal interface IColorSpectrum
	{
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000913 RID: 2323
		// (set) Token: 0x06000914 RID: 2324
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000915 RID: 2325
		// (set) Token: 0x06000916 RID: 2326
		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		Vector4 HsvColor
		{
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
			get;
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
			[param: In]
			set;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000917 RID: 2327
		// (set) Token: 0x06000918 RID: 2328
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000919 RID: 2329
		// (set) Token: 0x0600091A RID: 2330
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600091B RID: 2331
		// (set) Token: 0x0600091C RID: 2332
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600091D RID: 2333
		// (set) Token: 0x0600091E RID: 2334
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600091F RID: 2335
		// (set) Token: 0x06000920 RID: 2336
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000921 RID: 2337
		// (set) Token: 0x06000922 RID: 2338
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000923 RID: 2339
		// (set) Token: 0x06000924 RID: 2340
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		ColorSpectrumShape Shape
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			[param: In]
			set;
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000925 RID: 2341
		// (set) Token: 0x06000926 RID: 2342
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		ColorSpectrumComponents Components
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000927 RID: 2343
		// (remove) Token: 0x06000928 RID: 2344
		event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorChanged;
	}
}
