using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E7 RID: 487
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(IMonochromaticOverlayPresenterFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(IMonochromaticOverlayPresenterStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class MonochromaticOverlayPresenter : Grid, IMonochromaticOverlayPresenter
	{
		// Token: 0x06000993 RID: 2451
		public extern MonochromaticOverlayPresenter();

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000994 RID: 2452
		// (set) Token: 0x06000995 RID: 2453
		public extern UIElement SourceElement
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000996 RID: 2454
		// (set) Token: 0x06000997 RID: 2455
		public extern Color ReplacementColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000998 RID: 2456
		public static extern DependencyProperty SourceElementProperty { get; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000999 RID: 2457
		public static extern DependencyProperty ReplacementColorProperty { get; }
	}
}
