using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x0200005C RID: 92
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class AnimatedFindVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x060000A8 RID: 168
		public extern AnimatedFindVisualSource();

		// Token: 0x060000A9 RID: 169
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AA RID: 170
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x060000AB RID: 171
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
