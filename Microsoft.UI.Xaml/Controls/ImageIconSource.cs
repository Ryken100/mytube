using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000183 RID: 387
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IImageIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[Composable(typeof(IImageIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class ImageIconSource : IconSource, IImageIconSource
	{
		// Token: 0x060006A6 RID: 1702
		public extern ImageIconSource();

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060006A7 RID: 1703
		// (set) Token: 0x060006A8 RID: 1704
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern ImageSource ImageSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060006A9 RID: 1705
		public static extern DependencyProperty ImageSourceProperty { get; }
	}
}
