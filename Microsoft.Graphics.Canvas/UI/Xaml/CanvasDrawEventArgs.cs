using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000EE RID: 238
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(typeof(ICanvasDrawEventArgsFactory), 167772160U)]
	public sealed class CanvasDrawEventArgs : ICanvasDrawEventArgs
	{
		// Token: 0x0600079D RID: 1949
		public extern CanvasDrawEventArgs([In] CanvasDrawingSession canvasDrawingSession);

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600079E RID: 1950
		public extern CanvasDrawingSession DrawingSession { get; }
	}
}
