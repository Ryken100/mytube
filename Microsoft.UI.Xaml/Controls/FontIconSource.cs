using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000074 RID: 116
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Threading(3)]
	[Static(typeof(IFontIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IFontIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class FontIconSource : IconSource, IFontIconSource
	{
		// Token: 0x0600012F RID: 303
		public extern FontIconSource();

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000130 RID: 304
		// (set) Token: 0x06000131 RID: 305
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern string Glyph
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000132 RID: 306
		// (set) Token: 0x06000133 RID: 307
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "20.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "20.0")]
		public extern double FontSize
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "20.0")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "20.0")]
			[param: In]
			set;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000134 RID: 308
		// (set) Token: 0x06000135 RID: 309
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
		[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
		public extern FontFamily FontFamily
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::FontFamily{ c_fontIconSourceDefaultFontFamily }")]
			[param: In]
			set;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000136 RID: 310
		// (set) Token: 0x06000137 RID: 311
		[MUXPropertyDefaultValue(value = "{ 400 }")]
		[MUXPropertyDefaultValue(value = "{ 400 }")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern FontWeight FontWeight
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "{ 400 }")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "{ 400 }")]
			[param: In]
			set;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000138 RID: 312
		// (set) Token: 0x06000139 RID: 313
		[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
		public extern FontStyle FontStyle
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::FontStyle::Normal")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600013A RID: 314
		// (set) Token: 0x0600013B RID: 315
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsTextScaleFactorEnabled
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600013C RID: 316
		// (set) Token: 0x0600013D RID: 317
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool MirroredWhenRightToLeft
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600013E RID: 318
		public static extern DependencyProperty GlyphProperty { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600013F RID: 319
		public static extern DependencyProperty FontSizeProperty { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000140 RID: 320
		public static extern DependencyProperty FontFamilyProperty { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000141 RID: 321
		public static extern DependencyProperty FontWeightProperty { get; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000142 RID: 322
		public static extern DependencyProperty FontStyleProperty { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000143 RID: 323
		public static extern DependencyProperty IsTextScaleFactorEnabledProperty { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000144 RID: 324
		public static extern DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
