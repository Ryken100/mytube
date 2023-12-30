using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x0200005A RID: 90
	[WebHostHidden]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class AnimatedChevronRightDownSmallVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x060000A0 RID: 160
		public extern AnimatedChevronRightDownSmallVisualSource();

		// Token: 0x060000A1 RID: 161
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A2 RID: 162
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x060000A3 RID: 163
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
