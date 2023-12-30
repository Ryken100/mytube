using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x0200005D RID: 93
	[MarshalingBehavior(2)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public sealed class AnimatedGlobalNavigationButtonVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x060000AC RID: 172
		public extern AnimatedGlobalNavigationButtonVisualSource();

		// Token: 0x060000AD RID: 173
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AE RID: 174
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x060000AF RID: 175
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
