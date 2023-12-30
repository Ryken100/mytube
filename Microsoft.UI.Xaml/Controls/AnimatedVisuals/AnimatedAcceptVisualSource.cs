using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	// Token: 0x02000057 RID: 87
	[Threading(3)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class AnimatedAcceptVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		// Token: 0x06000094 RID: 148
		public extern AnimatedAcceptVisualSource();

		// Token: 0x06000095 RID: 149
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000096 RID: 150
		public extern IMapView<string, double> Markers { get; }

		// Token: 0x06000097 RID: 151
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
