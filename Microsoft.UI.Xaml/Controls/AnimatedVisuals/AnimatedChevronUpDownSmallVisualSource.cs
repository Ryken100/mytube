using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x0200005B RID: 91
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public sealed class AnimatedChevronUpDownSmallVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x060000A4 RID: 164
		public extern AnimatedChevronUpDownSmallVisualSource();

		// Token: 0x060000A5 RID: 165
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A6 RID: 166
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x060000A7 RID: 167
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
