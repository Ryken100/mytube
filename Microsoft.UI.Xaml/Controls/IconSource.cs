using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000054 RID: 84
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Bindable]
	[Composable(typeof(IIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class IconSource : DependencyObject, IIconSource
	{
		// Token: 0x06000068 RID: 104
		public extern IconElement CreateIconElement();

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000069 RID: 105
		// (set) Token: 0x0600006A RID: 106
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Brush Foreground
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600006B RID: 107
		public static extern DependencyProperty ForegroundProperty { get; }
	}
}
