using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007E RID: 126
	[WebHostHidden]
	[Guid(2762848805U, 41804, 23930, 189, 64, 97, 224, 221, 202, 18, 152)]
	[ExclusiveTo(typeof(AnimatedVisualPlayer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAnimatedVisualPlayerStatics
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000174 RID: 372
		DependencyProperty AutoPlayProperty { get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000175 RID: 373
		DependencyProperty DiagnosticsProperty { get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000176 RID: 374
		DependencyProperty DurationProperty { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000177 RID: 375
		DependencyProperty FallbackContentProperty { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000178 RID: 376
		DependencyProperty IsAnimatedVisualLoadedProperty { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000179 RID: 377
		DependencyProperty IsPlayingProperty { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600017A RID: 378
		DependencyProperty PlaybackRateProperty { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600017B RID: 379
		DependencyProperty SourceProperty { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600017C RID: 380
		DependencyProperty StretchProperty { get; }
	}
}
