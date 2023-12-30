using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000056 RID: 86
	[WebHostHidden]
	[Static(typeof(IAnimatedVisualPlayerStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "Source")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IAnimatedVisualPlayerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class AnimatedVisualPlayer : FrameworkElement, IAnimatedVisualPlayer
	{
		// Token: 0x06000076 RID: 118
		public extern AnimatedVisualPlayer();

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119
		public extern object Diagnostics { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120
		public extern TimeSpan Duration { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000079 RID: 121
		// (set) Token: 0x0600007A RID: 122
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IAnimatedVisualSource Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007B RID: 123
		// (set) Token: 0x0600007C RID: 124
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern DataTemplate FallbackContent
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007D RID: 125
		// (set) Token: 0x0600007E RID: 126
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool AutoPlay
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007F RID: 127
		public extern bool IsAnimatedVisualLoaded { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000080 RID: 128
		public extern bool IsPlaying { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129
		// (set) Token: 0x06000082 RID: 130
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "1")]
		public extern double PlaybackRate
		{
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000083 RID: 131
		public extern CompositionObject ProgressObject { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000084 RID: 132
		// (set) Token: 0x06000085 RID: 133
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		public extern Stretch Stretch
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x06000086 RID: 134
		public extern void Pause();

		// Token: 0x06000087 RID: 135
		public extern IAsyncAction PlayAsync([In] double fromProgress, [In] double toProgress, [In] bool looped);

		// Token: 0x06000088 RID: 136
		public extern void Resume();

		// Token: 0x06000089 RID: 137
		public extern void SetProgress([In] double progress);

		// Token: 0x0600008A RID: 138
		public extern void Stop();

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008B RID: 139
		public static extern DependencyProperty AutoPlayProperty { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008C RID: 140
		public static extern DependencyProperty DiagnosticsProperty { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008D RID: 141
		public static extern DependencyProperty DurationProperty { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008E RID: 142
		public static extern DependencyProperty FallbackContentProperty { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008F RID: 143
		public static extern DependencyProperty IsAnimatedVisualLoadedProperty { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144
		public static extern DependencyProperty IsPlayingProperty { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000091 RID: 145
		public static extern DependencyProperty PlaybackRateProperty { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000092 RID: 146
		public static extern DependencyProperty SourceProperty { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000093 RID: 147
		public static extern DependencyProperty StretchProperty { get; }
	}
}
