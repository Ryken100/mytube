using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000055 RID: 85
	[MarshalingBehavior(2)]
	[Composable(typeof(IAnimatedIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IAnimatedIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class AnimatedIconSource : IconSource, IAnimatedIconSource
	{
		// Token: 0x0600006C RID: 108
		public extern AnimatedIconSource();

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109
		// (set) Token: 0x0600006E RID: 110
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IAnimatedVisualSource2 Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006F RID: 111
		// (set) Token: 0x06000070 RID: 112
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IconSource FallbackIconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x06000072 RID: 114
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000073 RID: 115
		public static extern DependencyProperty SourceProperty { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000074 RID: 116
		public static extern DependencyProperty FallbackIconSourceProperty { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000075 RID: 117
		public static extern DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
