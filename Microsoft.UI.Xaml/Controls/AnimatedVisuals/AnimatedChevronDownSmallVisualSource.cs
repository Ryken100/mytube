using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x02000059 RID: 89
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class AnimatedChevronDownSmallVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x0600009C RID: 156
		public extern AnimatedChevronDownSmallVisualSource();

		// Token: 0x0600009D RID: 157
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009E RID: 158
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x0600009F RID: 159
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
