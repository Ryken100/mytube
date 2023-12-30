using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001B0 RID: 432
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(IPathIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IPathIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	public class PathIconSource : IconSource, IPathIconSource
	{
		// Token: 0x06000863 RID: 2147
		public extern PathIconSource();

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000864 RID: 2148
		// (set) Token: 0x06000865 RID: 2149
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Geometry Data
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000866 RID: 2150
		public static extern DependencyProperty DataProperty { get; }
	}
}
