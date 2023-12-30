using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000ED RID: 237
	[Version(167772160U)]
	[Guid(1922684716U, 63716, 18991, 158, 48, 124, 223, 204, 243, 28, 68)]
	[ExclusiveTo(typeof(CanvasDrawEventArgs))]
	internal interface ICanvasDrawEventArgsFactory
	{
		// Token: 0x0600079C RID: 1948
		CanvasDrawEventArgs Create([In] CanvasDrawingSession canvasDrawingSession);
	}
}
