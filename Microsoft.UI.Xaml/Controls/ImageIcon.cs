using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000182 RID: 386
	[WebHostHidden]
	[Composable(typeof(IImageIconFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IImageIconStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class ImageIcon : IconElement, IImageIcon
	{
		// Token: 0x060006A2 RID: 1698
		public extern ImageIcon();

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060006A3 RID: 1699
		// (set) Token: 0x060006A4 RID: 1700
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern ImageSource Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060006A5 RID: 1701
		public static extern DependencyProperty SourceProperty { get; }
	}
}
