using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000053 RID: 83
	[Static(typeof(IAnimatedIconStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContentProperty(Name = "Source")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IAnimatedIconFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class AnimatedIcon : IconElement, IAnimatedIcon
	{
		// Token: 0x0600005B RID: 91
		public extern AnimatedIcon();

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005C RID: 92
		// (set) Token: 0x0600005D RID: 93
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005E RID: 94
		// (set) Token: 0x0600005F RID: 95
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000060 RID: 96
		// (set) Token: 0x06000061 RID: 97
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000062 RID: 98
		[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
		public static extern DependencyProperty StateProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
			get;
		}

		// Token: 0x06000063 RID: 99
		public static extern void SetState([In] DependencyObject @object, [In] string value);

		// Token: 0x06000064 RID: 100
		public static extern string GetState([In] DependencyObject @object);

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101
		public static extern DependencyProperty SourceProperty { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000066 RID: 102
		public static extern DependencyProperty FallbackIconSourceProperty { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103
		public static extern DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
