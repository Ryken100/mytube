using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007C RID: 124
	[WebHostHidden]
	[Guid(3212806245U, 31609, 21332, 151, 136, 194, 30, 82, 53, 145, 234)]
	[ExclusiveTo(typeof(AnimatedVisualPlayer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAnimatedVisualPlayer
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600015F RID: 351
		object Diagnostics { get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000160 RID: 352
		TimeSpan Duration { get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000161 RID: 353
		// (set) Token: 0x06000162 RID: 354
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IAnimatedVisualSource Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000163 RID: 355
		// (set) Token: 0x06000164 RID: 356
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		DataTemplate FallbackContent
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000165 RID: 357
		// (set) Token: 0x06000166 RID: 358
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool AutoPlay
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000167 RID: 359
		bool IsAnimatedVisualLoaded { get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000168 RID: 360
		bool IsPlaying { get; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000169 RID: 361
		// (set) Token: 0x0600016A RID: 362
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		double PlaybackRate
		{
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600016B RID: 363
		CompositionObject ProgressObject { get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600016C RID: 364
		// (set) Token: 0x0600016D RID: 365
		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		Stretch Stretch
		{
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			[param: In]
			set;
		}

		// Token: 0x0600016E RID: 366
		void Pause();

		// Token: 0x0600016F RID: 367
		IAsyncAction PlayAsync([In] double fromProgress, [In] double toProgress, [In] bool looped);

		// Token: 0x06000170 RID: 368
		void Resume();

		// Token: 0x06000171 RID: 369
		void SetProgress([In] double progress);

		// Token: 0x06000172 RID: 370
		void Stop();
	}
}
