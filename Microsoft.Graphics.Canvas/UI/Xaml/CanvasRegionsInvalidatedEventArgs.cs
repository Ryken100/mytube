using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F7 RID: 247
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasRegionsInvalidatedEventArgs : ICanvasRegionsInvalidatedEventArgs
	{
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060007FC RID: 2044
		public extern Rect[] InvalidatedRegions { get; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060007FD RID: 2045
		public extern Rect VisibleRegion { get; }
	}
}
