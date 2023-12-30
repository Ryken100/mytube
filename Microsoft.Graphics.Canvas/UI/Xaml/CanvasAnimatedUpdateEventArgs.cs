using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E2 RID: 226
	[MarshalingBehavior(2)]
	[Activatable(typeof(ICanvasAnimatedUpdateEventArgsFactory), 167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasAnimatedUpdateEventArgs : ICanvasAnimatedUpdateEventArgs
	{
		// Token: 0x06000742 RID: 1858
		public extern CanvasAnimatedUpdateEventArgs([In] CanvasTimingInformation timingInformation);

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000743 RID: 1859
		public extern CanvasTimingInformation Timing { get; }
	}
}
