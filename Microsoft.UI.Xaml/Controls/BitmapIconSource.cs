using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000060 RID: 96
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IBitmapIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Composable(typeof(IBitmapIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class BitmapIconSource : IconSource, IBitmapIconSource
	{
		// Token: 0x060000B7 RID: 183
		public extern BitmapIconSource();

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B8 RID: 184
		// (set) Token: 0x060000B9 RID: 185
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Uri UriSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BA RID: 186
		// (set) Token: 0x060000BB RID: 187
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool ShowAsMonochrome
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BC RID: 188
		public static extern DependencyProperty UriSourceProperty { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BD RID: 189
		public static extern DependencyProperty ShowAsMonochromeProperty { get; }
	}
}
