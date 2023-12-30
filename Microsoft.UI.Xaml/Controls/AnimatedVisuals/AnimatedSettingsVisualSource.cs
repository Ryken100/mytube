using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x0200005E RID: 94
	[WebHostHidden]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class AnimatedSettingsVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x060000B0 RID: 176
		public extern AnimatedSettingsVisualSource();

		// Token: 0x060000B1 RID: 177
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B2 RID: 178
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x060000B3 RID: 179
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
