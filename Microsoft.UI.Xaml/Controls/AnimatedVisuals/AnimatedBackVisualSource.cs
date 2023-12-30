using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x02000058 RID: 88
	[Threading(3)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	public sealed class AnimatedBackVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x06000098 RID: 152
		public extern AnimatedBackVisualSource();

		// Token: 0x06000099 RID: 153
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009A RID: 154
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x0600009B RID: 155
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
